using System.Collections;
using System.Collections.Generic;
using templates_flyweight_.@abstract.factories;
using templates_flyweight_.@abstract.style;
using templates_flyweight_.concrete.style;

namespace templates_flyweight_.concrete.factories
{
    public class StyleFactory : IStyleFactory
    {
        private readonly Hashtable _table = new Hashtable(new Dictionary<string, IStyle>());

        public IStyle GetStyle(int pointSize, string textStyle)
        {
            var returnStyle = (IStyle)_table[textStyle + pointSize];

            if (returnStyle == null)
            {
                returnStyle = CreateStyle(pointSize, textStyle);

                _table.Add(textStyle + pointSize, returnStyle);
            }

            return returnStyle;
        }

        private static IStyle CreateStyle(int pointSize, string textStyle)
        {
            return new Style
                       {
                           FontStyle = textStyle, PointSize = pointSize
                       };
        }
    }
}
