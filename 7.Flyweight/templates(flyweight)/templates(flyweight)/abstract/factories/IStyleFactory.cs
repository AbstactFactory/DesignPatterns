using templates_flyweight_.@abstract.style;

namespace templates_flyweight_.@abstract.factories
{
	public interface IStyleFactory
	{
	    IStyle GetStyle(int pointSize, string textStyle);
	}
}
