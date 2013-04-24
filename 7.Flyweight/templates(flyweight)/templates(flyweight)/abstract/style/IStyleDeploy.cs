namespace templates_flyweight_.@abstract.style
{
	public interface IStyleDeploy
	{
        IStyle Style { get; set; }

        int StartPos { get; set; }

        int EndPos { get; set; }
	}
}
