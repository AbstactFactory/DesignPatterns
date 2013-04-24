using templates_flyweight_.@abstract.style;

namespace templates_flyweight_.concrete.style
{
    class StyleDeploy : IStyleDeploy
    {
        public IStyle Style { get; set; }

        public int StartPos { get; set; }

        public int EndPos { get; set; }
    }
}
