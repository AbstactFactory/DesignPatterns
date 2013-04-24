using System.Drawing;
using templates_flyweight_.@abstract.style;

namespace templates_flyweight_.@abstract.factories
{
	public interface IBitmapFactory
	{
	    Bitmap GetImage(char Char, IStyle style);
	}
}
