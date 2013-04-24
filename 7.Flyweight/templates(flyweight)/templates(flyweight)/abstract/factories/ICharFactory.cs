using templates_flyweight_.@abstract.character;

namespace templates_flyweight_.@abstract.factories
{
	public interface ICharFactory
	{
	    ICharacter GetCharacter(char Char);
	}
}
