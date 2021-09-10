using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating a new Bitmap object
            Bitmap captureBitmap = new Bitmap(300, 300, PixelFormat.Format32bppArgb);

            //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);  
            //Creating a Rectangle object which will  
            //capture our Current Screen
            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;

            //Creating a New Graphics Object
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);

            //Copying Image from The Screen
            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

            //Saving the Image File
            captureBitmap.Save(@"D:\Capture2.jpg", ImageFormat.Jpeg);

            Image<Gray, byte> sourceImage = new Image<Gray, byte>(@"D:\Capture2.jpg");
            Image<Gray, byte> templateImage = new Image<Gray, byte>(@"D:\Capture.jpg");
            Image<Gray, float> resultImage = sourceImage.MatchTemplate(templateImage, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);

            //Displaying the Successfull Result 
            MessageBox.Show($"Screen Captured, Score: {resultImage.Data[0,0,0]}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A clicked");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VirtualMouse.SetCursorPos(102, 363);
            VirtualMouse.LeftClick();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            var pt = new Point();

            VirtualMouse.GetCursorPos(ref pt);
            mouseXLabel.Text = pt.X.ToString();
            mouseYLabel.Text = pt.Y.ToString();
        }
    }
}
