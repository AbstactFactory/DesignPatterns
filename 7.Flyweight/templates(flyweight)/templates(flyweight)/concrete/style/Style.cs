using templates_flyweight_.@abstract.style;

namespace templates_flyweight_.concrete.style
{
    public class Style : IStyle
    {
        public string FontStyle { get; set; }

        public int PointSize { get; set; }
    }
}
