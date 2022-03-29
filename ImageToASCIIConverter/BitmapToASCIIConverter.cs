using System.Drawing;

namespace ImageToASCIIConverter
{
    public class BitmapToASCIIConverter
    {
        private readonly char[] _asciiTable = { '.', ',', ':', '+', '*', '?', '%', 'S', '#', '@' };
        private readonly char[] _asciiTableReverse = { '@', '#', 'S', '%', '?', '*', '+', ':', ',', '.' };

        private readonly Bitmap _bitmap;

        public BitmapToASCIIConverter(Bitmap bitmap)
        {
            _bitmap = bitmap;
        }

        public char[][] ConvertToConsole()
        {
            return Convert(_asciiTable);
        }

        public char[][] ConvertToFile()
        {
            return Convert(_asciiTableReverse);
        }

        private char[][] Convert(char[] asciiTable)
        {
            char[][] result = new char[_bitmap.Height][];

            for (int y = 0; y < _bitmap.Height; y++)
            {
                result[y] = new char[_bitmap.Width];

                for (int x = 0; x < _bitmap.Width; x++)
                {
                    int mapIndex = (int)Map(_bitmap.GetPixel(x, y).R, 255, asciiTable.Length - 1);
                    result[y][x] = asciiTable[mapIndex];
                }
            }
            return result;
        }

        private float Map(float valueToMap, float bound1, float bound2)
        {
            return valueToMap * bound2 / bound1;
        }
    }
}
