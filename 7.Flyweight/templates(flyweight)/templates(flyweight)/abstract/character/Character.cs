using System.Drawing;
using templates_flyweight_.@abstract.factories;
using templates_flyweight_.@abstract.style;
using Point = templates_flyweight_.structs.Point;

namespace templates_flyweight_.@abstract.character
{
    public abstract class Character : ICharacter
    {
        public char Char { get; protected set; }
        
        public void Display(Point point, IStyle style, IBitmapFactory factory)
        {
            DrawBitmap(factory.GetImage(Char, style), point);
        }

        private static void DrawBitmap(Bitmap bitmap, Point point)
        {
        }
    }
}
