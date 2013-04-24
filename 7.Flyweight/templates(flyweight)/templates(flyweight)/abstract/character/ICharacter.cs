using templates_flyweight_.@abstract.factories;
using templates_flyweight_.@abstract.style;
using templates_flyweight_.structs;

namespace templates_flyweight_.@abstract.character
{
	public interface ICharacter
	{
        char Char { get; }

	    void Display(Point point, IStyle style, IBitmapFactory factory);
	}
}
