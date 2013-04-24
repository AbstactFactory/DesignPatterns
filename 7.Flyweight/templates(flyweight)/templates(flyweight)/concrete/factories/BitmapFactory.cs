using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using templates_flyweight_.@abstract.factories;
using templates_flyweight_.@abstract.style;

namespace templates_flyweight_.concrete.factories
{
    public class BitmapFactory : IBitmapFactory
    {
        private readonly Hashtable _table = new Hashtable(new Dictionary<string, Bitmap>());

        public Bitmap GetImage(char Char, IStyle style)
        {
            var key = Char + style.ToString();
            
            var bitmap = (Bitmap) _table[key];
            
            if(bitmap == null)
            {
                bitmap = CreateBitmap(Char, style);

                _table.Add(key, bitmap);
            }

            return bitmap;
        }

        private static Bitmap CreateBitmap(char Char, IStyle style)
        {
            return new Bitmap(Char + style.ToString());
        }
    }
}
