using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataOnImage
{
    public partial class FrmDataOnImage : Form
    {
        public FrmDataOnImage()
        {
            InitializeComponent();
        }

        Bitmap bmp;
        string headerTextData = "msf text data on image ";
        string headerFileData = "msf file data on image ";

        private void btnWriteDataOnImage_Click(object sender, EventArgs e)
        {
            string strData = headerTextData + Encoding.UTF8.GetBytes(rtxData.Text).Length.ToString("D11") + rtxData.Text;

            byte[] data = Encoding.UTF8.GetBytes(strData);

            int canBeWriteLength = (int)Math.Ceiling(((double)bmp.Width * bmp.Height * 3) / 8);
            if (data.Length > canBeWriteLength)
            {
                double megaPixels = Math.Ceiling((double)data.Length * 8 / 3 / 1000) / 1000;
                double picMegaPixel = Math.Round((double)bmp.Width * bmp.Height / 1000) / 1000;
                MessageBox.Show("your image aproximately must be " + megaPixels + " mega Pixels  in least to store your data. but your image's mega pixel is " + picMegaPixel);
                return;
            }

            writeToImage(data, bmp);
            MessageBox.Show("Data writed on Image");

        }

        private static void writeToImage(byte[] data, Bitmap bmp)
        {
            int bitInByte = 0;
            int byteIndex = 0;
            bool notReachedEndOfArray = true;
            for (int x = 0; x < bmp.Width & notReachedEndOfArray; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {

                    Color color = bmp.GetPixel(x, y);

                    byte r = color.R;
                    byte g = color.G;
                    byte b = color.B;

                    if (SetBitValueToColorAndIncreaseVariables(data, ref bitInByte, ref byteIndex, ref r))
                    {
                        notReachedEndOfArray = false;
                        Color colorToSet = Color.FromArgb(r, g, b);
                        bmp.SetPixel(x, y, colorToSet);
                        break;
                    }

                    if (SetBitValueToColorAndIncreaseVariables(data, ref bitInByte, ref byteIndex, ref g))
                    {
                        notReachedEndOfArray = false;
                        Color colorToSet = Color.FromArgb(r, g, b);
                        bmp.SetPixel(x, y, colorToSet);
                        break;
                    }

                    if (SetBitValueToColorAndIncreaseVariables(data, ref bitInByte, ref byteIndex, ref b))
                    {
                        notReachedEndOfArray = false;
                        Color colorToSet = Color.FromArgb(r, g, b);
                        bmp.SetPixel(x, y, colorToSet);
                        break;
                    }

                    Color colorToSet_ = Color.FromArgb(r, g, b);
                    bmp.SetPixel(x, y, colorToSet_);

                }

            }
        }

        private static bool SetBitValueToColorAndIncreaseVariables(byte[] data, ref int bitInByte, ref int byteIndex, ref byte singleColor)
        {
            int bitValueToSet;
            bitValueToSet = (data[byteIndex] & (1 << bitInByte)) == 0 ? 0 : 1;
            singleColor = GetNewByteValueAfterSetBitValue(singleColor, bitValueToSet);

            bitInByte++;
            if (bitInByte > 7)
            {
                byteIndex++;
                bitInByte = 0;
            }

            bool reachedEndOfArray;
            if (byteIndex > data.Length - 1)
                reachedEndOfArray = true;
            else
                reachedEndOfArray = false;
            return reachedEndOfArray;
        }

        private static bool GetBitValueFromColorAndSetItToArrayAndIncreaseVariables(byte[] data, ref int bitInByte, ref int byteIndex, byte singleColor)
        {
            byte bitValue = GetBitValueFromByte(singleColor);
            if (bitValue == 1)
            {
                data[byteIndex] = (byte)(data[byteIndex] | (1 << bitInByte));
            }
            else
            {
                data[byteIndex] = (byte)(data[byteIndex] & (~(1 << bitInByte)));

            }

            bitInByte++;
            if (bitInByte > 7)
            {
                byteIndex++;
                bitInByte = 0;
            }

            bool reachedEndOfArray;
            if (byteIndex > data.Length - 1)
                reachedEndOfArray = true;
            else
                reachedEndOfArray = false;
            return reachedEndOfArray;
        }


        private static byte GetNewByteValueAfterSetBitValue(byte byteValue, int bitValueToSet)
        {
            if (bitValueToSet == 0)
            {
                if (byteValue % 2 == 1)
                {
                    byteValue--;
                }
            }
            else
            {
                if (byteValue % 2 == 0)
                {
                    byteValue++;
                }
            }
            return byteValue;
        }

        private static byte GetBitValueFromByte(byte byteValue)
        {
            byte bitValue;
            if (byteValue % 2 == 0)
            {
                bitValue = 0;
            }
            else
            {
                bitValue = 1;
            }

            return bitValue;
        }


        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(txtImagePath.Text);
            picImage.Image = bmp;
            double picMegaPixel = Math.Round((double)bmp.Width * bmp.Height / 1000) / 1000;
            lblImageMegaPixel.Text = "Image:" + picMegaPixel+" MP";
        }

        private void btnReadTextDataFromImage_Click(object sender, EventArgs e)
        {

            byte[] readedHeaderData = new byte[headerTextData.Length + 11];


            readFromImage(readedHeaderData, bmp);

            string readedHeader = Encoding.ASCII.GetString(readedHeaderData);
            if (readedHeader.IndexOf(headerTextData) != 0)
            {
                MessageBox.Show("Header data is not valid.\r\n data is:" + readedHeader);
                return;
            }
            int len;
            if (!int.TryParse(readedHeader.Substring(headerTextData.Length), out len))
            {
                MessageBox.Show("Length is not valid.\r\n data is:" + readedHeader);
                return;
            }

            byte[] readedData = new byte[headerTextData.Length + 11 + len];
            readFromImage(readedData, bmp);
            string readedString = Encoding.UTF8.GetString(readedData);
            readedString = readedString.Substring(headerTextData.Length + 11);
            rtxData.Text = readedString;

        }

        private static void readFromImage(byte[] data, Bitmap bmp)
        {
            int bitInByte = 0;
            int byteIndex = 0;
            bool notReachedEndOfArray = true;
            for (int x = 0; x < bmp.Width & notReachedEndOfArray; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {

                    Color color = bmp.GetPixel(x, y);

                    byte r = color.R;
                    if (GetBitValueFromColorAndSetItToArrayAndIncreaseVariables(data, ref bitInByte, ref byteIndex, r))
                    {
                        notReachedEndOfArray = false;
                        break;
                    }

                    byte g = color.G;
                    if (GetBitValueFromColorAndSetItToArrayAndIncreaseVariables(data, ref bitInByte, ref byteIndex, g))
                    {
                        notReachedEndOfArray = false;
                        break;
                    }

                    byte b = color.B;
                    if (GetBitValueFromColorAndSetItToArrayAndIncreaseVariables(data, ref bitInByte, ref byteIndex, b))
                    {
                        notReachedEndOfArray = false;
                        break;
                    }

                }

            }
        }

        private void btnSowOpenDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtImagePath.Text = ofd.FileName;
                btnOpenImage_Click(sender, e);
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            string filePath = txtImagePath.Text;
            string toSavePath = Path.Combine(Path.GetDirectoryName(filePath), Path.GetFileNameWithoutExtension(filePath) + txtAddThisSuffix.Text + ".png");
            bmp.Save(toSavePath, System.Drawing.Imaging.ImageFormat.Png);
            MessageBox.Show("Image saved by PNG Format.\r\n in '" + toSavePath + "' path.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text += "  " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            //btnOpenImage_Click(sender, e);
        }

        private void btnReadFileDataFromImage_Click(object sender, EventArgs e)
        {
            byte[] readedHeaderData = new byte[headerFileData.Length + 11];
            readFromImage(readedHeaderData, bmp);

            string readedHeader = Encoding.ASCII.GetString(readedHeaderData);
            if (readedHeader.IndexOf(headerFileData) != 0)
            {
                MessageBox.Show("Header data is not valid.\r\n data is:" + readedHeader);
                return;
            }
            int len;
            if (!int.TryParse(readedHeader.Substring(headerFileData.Length), out len))
            {
                MessageBox.Show("Length is not valid\r\n data is:" + readedHeader);
                return;
            }

            byte[] readedData = new byte[headerFileData.Length + 11 + len];
            readFromImage(readedData, bmp);

            byte[] DataWithFileName = new byte[len];
            Array.Copy(readedData, headerFileData.Length + 11, DataWithFileName, 0, len);

            byte[] fileNameLengthStrData = new byte[5];
            Array.Copy(DataWithFileName, 0, fileNameLengthStrData, 0, fileNameLengthStrData.Length);
            int fileNameLen = int.Parse(Encoding.ASCII.GetString(fileNameLengthStrData));

            byte[] fileNameStrData = new byte[fileNameLen];
            Array.Copy(DataWithFileName, fileNameLengthStrData.Length, fileNameStrData, 0, fileNameStrData.Length);
            string fileName = Encoding.UTF8.GetString(fileNameStrData);

            byte[] pureData = new byte[DataWithFileName.Length - (fileNameLengthStrData.Length + fileNameStrData.Length)];
            Array.Copy(DataWithFileName, fileNameLengthStrData.Length + fileNameStrData.Length, pureData, 0, pureData.Length);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = fileName;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filePathToSave = sfd.FileName;
                File.WriteAllBytes(filePathToSave, pureData);
            }

            MessageBox.Show("Data readed and saved.");

        }

        private void btnWriteFileDataOnImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filePath = ofd.FileName;
                byte[] fileData = File.ReadAllBytes(filePath);
                //string strData = headerFileData + Encoding.UTF8.GetBytes(txtData.Text).Length.ToString("D11") + txtData.Text;
                string fileNameOnly = Path.GetFileName(filePath);
                string fileNameHeader = Encoding.UTF8.GetBytes(fileNameOnly).Length.ToString("D5") + fileNameOnly;
                int fileNameHeaderLength = Encoding.UTF8.GetBytes(fileNameHeader).Length;
                string header = headerFileData + (fileNameHeaderLength + fileData.Length).ToString("D11") + fileNameHeader;

                byte[] utf8Data = Encoding.UTF8.GetBytes(header);
                byte[] allData = new byte[utf8Data.Length + fileData.Length];
                utf8Data.CopyTo(allData, 0);
                fileData.CopyTo(allData, utf8Data.Length);


                //byte[] data = headerFileData + fileData.Length.ToString("D5") +

                int canBeWriteLength = (int)Math.Ceiling(((double)bmp.Width * bmp.Height * 3) / 8);
                if (allData.Length > canBeWriteLength)
                {
                    double megaPixels = Math.Ceiling((double)allData.Length * 8 / 3 / 1000) / 1000;
                    double picMegaPixel = Math.Round((double)bmp.Width * bmp.Height / 1000) / 1000;
                    MessageBox.Show("your image aproximately must be " + megaPixels + " mega Pixels in least to store your data. but your image's mega pixel is " + picMegaPixel);
                    return;
                }

                writeToImage(allData, bmp);
                MessageBox.Show("Data writed on Image");

            }

        }

        private void btnCalculateNeededMegaPixel_Click(object sender, EventArgs e)
        {
            string strData = headerTextData + Encoding.UTF8.GetBytes(rtxData.Text).Length.ToString("D11") + rtxData.Text;
            byte[] data = Encoding.UTF8.GetBytes(strData);
            double megaPixels = Math.Ceiling((double)data.Length * 8 / 3 / 1000) / 1000;
            lblNeededMegaPixel.Text = "  Need:" + megaPixels + " MP";

        }

        private void btnReadDataFromImageAutoDetect_Click(object sender, EventArgs e)
        {
            byte[] readedHeaderData = new byte[headerTextData.Length + 11];

            readFromImage(readedHeaderData, bmp);

            string readedHeader = Encoding.ASCII.GetString(readedHeaderData);
            if (readedHeader.IndexOf(headerTextData) == 0)
            {
                btnReadTextDataFromImage_Click(sender, e);
            }
            else if (readedHeader.IndexOf(headerFileData) == 0)
            {
                btnReadFileDataFromImage_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Header data is not valid.\r\n data is:" + readedHeader);
                return;
            }

        }




        //-----------------------------------------------------------------------------------
    }
}
