using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

using DotImaging;

namespace ImageClicker2
{
    class TemplateImage
    {
        string _Name;
        Bgr<byte>[,] _BitmapArray;

        Size _Size;

        public TemplateImage(string name, Bitmap image)
        {
            this._Name = name;
            this._BitmapArray = BitmapToBgrByte(image);
            this._Size = image.Size;
        }

        public string Name
        {
            get { return _Name;}
        }

        public Bgr<byte>[,] BitmapArray
        {
            get { return _BitmapArray; }
        }

        public Size Size
        {
            get { return _Size; }
        }

        public char Group
        {
            get { return _Name[0]; }
        }

        Bgr<byte>[,] BitmapToBgrByte(Bitmap source)
        {
            Bgr<byte>[,] byteArray = new Bgr<byte>[source.Width, source.Height];

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixelColor = source.GetPixel(x, y);
                    byteArray[x, y] = new Bgr<byte>(pixelColor.B, pixelColor.G, pixelColor.R);
                }
            }

            return byteArray;
        }

    }
}
