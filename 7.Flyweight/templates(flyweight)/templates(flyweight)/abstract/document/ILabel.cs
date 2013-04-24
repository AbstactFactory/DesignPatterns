using templates_flyweight_.@abstract.factories;
using templates_flyweight_.@abstract.style;

namespace templates_flyweight_.@abstract.document
{
	public interface ILabel
	{
        string Text { get; set; }

	    void Display();

        void ChangeStyle(int startPos, int endPos, int pointSize, string fontStyle);
	}
}
