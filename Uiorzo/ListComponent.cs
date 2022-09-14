namespace Uiorzo;

public class ListComponent : IComponent
{
    private readonly int _left;
    private readonly int _top;

    public ListComponent(int left, int top)
    {
        _left = left;
        _top = top;
    }

    public void SetList(List<string> list) 
    {

    }

    public void Draw()
    {
        Console.SetCursorPosition(_left, _top);
        Console.Write("FirstWordInList");
    }
}
