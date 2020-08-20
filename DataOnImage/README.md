# Description
This program hide text or file data on image (Steganography).

Saved image format is PNG because it must be lossless.

I save one bit per color. One bit in red, one bit in blue and one bit in green. So I save 3 bits in each pixel.
Then to save n bytes of data you need (n * 8 / 3 + header_data) Pixels. For example to save 1MB data, you need more than (1 * 1024 * 1024 * 8 / 3) pixels, aproximately 2.8 Mpixel image.

The result image quality is good and the changes is not perceptible.

It is simple to use:

Run the program (direct executable file link: https://github.com/mostafavtp/cs_projs/blob/master/DataOnImage/release/DataOnImage.exe . It built by .Net framework 4.0 that exist on most windows systems) Then:

To save data:
  1. Click on "..." button to select an image.
  2. Click on "Write File Data On Image" button to select a file.
  3. Click on "SaveImage" button to save the PNG image.

To restore data:
  1. Click on "..." button to select an image that previously saved by this program.
  2. Click on "Read Data From Image" button to save the data file.
  
That's it.

If the data is confidential then encrypt it (by 7zip, WinRar or ...) before hiding it in image by this program. Because of everyone that has this program can extract the data from the image.
