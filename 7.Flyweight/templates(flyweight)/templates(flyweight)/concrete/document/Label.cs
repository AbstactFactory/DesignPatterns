using System.Collections.Generic;
using templates_flyweight_.@abstract.character;
using templates_flyweight_.@abstract.document;
using templates_flyweight_.@abstract.factories;
using templates_flyweight_.@abstract.style;
using templates_flyweight_.concrete.factories;
using templates_flyweight_.concrete.style;
using templates_flyweight_.structs;

namespace templates_flyweight_.concrete.document
{
    public class Label : ILabel
    {
        private string _text;
        
        private readonly IBitmapFactory _bitmapFactory;
        private readonly ICharFactory _charFactory;
        private readonly IStyleFactory _styleFactory;

        private IList<ICharacter> _characters;
        private IList<IStyleDeploy> _styles; 

        public Label()
        {
            _text = "AAAABBBBBCCCCCC";

            _bitmapFactory = new BitmapFactory();
            _charFactory = new CharFactory();
            _styleFactory = new StyleFactory();

            Update();
        }

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                Update();
            }
        }
        
        public void Display()
        {
            var j = 0;
            var style = _styles[j++];

            for(var i = 0; i < _characters.Count; ++i)
            {
                if (i > style.EndPos)
                {
                    style = _styles[j++];
                }

                _characters[i].Display(new Point
                                           {
                                               X = style.Style.PointSize, 
                                               Y = 10
                                           }, style.Style, _bitmapFactory );
            }
        }

        public void ChangeStyle(int startPos, int endPos, int pointSize, string fontStyle)
        {
            // добавить пересчет позиций применения в _styles
            _styles.Add(new StyleDeploy
            {
                StartPos = startPos, 
                EndPos = endPos, 
                Style = _styleFactory.GetStyle(pointSize, fontStyle)
            });

            Display();
        }

        private void FillCharacters()
        {
            _characters = new List<ICharacter>();

            foreach (var symbol in Text)
            {
                _characters.Add(_charFactory.GetCharacter(symbol));
            }
        }

        private void SetDefaultStyle()
        {
            _styles = new List<IStyleDeploy>
                          {
                              new StyleDeploy
                                  {
                                      StartPos = 0,
                                      EndPos = _text.Length,
                                      Style = _styleFactory.GetStyle(12, "Default")
                                  }
                          };
        }

        private void Update()
        {
            FillCharacters();
            SetDefaultStyle();
        }
    }
}
