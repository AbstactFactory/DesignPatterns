using System.Collections;
using System.Collections.Generic;
using templates_flyweight_.@abstract.character;
using templates_flyweight_.@abstract.factories;
using templates_flyweight_.concrete.characters;

namespace templates_flyweight_.concrete.factories
{
    public class CharFactory : ICharFactory
    {
        private readonly Hashtable _table = new Hashtable(new Dictionary<char, ICharacter>());

        public ICharacter GetCharacter(char Char)
        {
            var returnChar = (ICharacter)_table[Char];

            if(returnChar == null)
            {
                returnChar = CreateCharacter(Char);

                _table.Add(Char, returnChar);
            }

            return returnChar;
        }

        private static ICharacter CreateCharacter(char Char)
        {
            ICharacter createdCharacter;

            switch(Char)
            {
                case 'A':
                    createdCharacter = new CharacterA();
                    break;
                case 'B':
                    createdCharacter = new CharacterB();
                    break;
                default:
                    createdCharacter = new CharacterC();
                    break;
            }

            return createdCharacter;
        }
    }
}
