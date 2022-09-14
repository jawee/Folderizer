namespace Uiorzo;

public class InputComponent : IComponent
{
    public void Draw()
    {
        var posLeft = 0;
        var posTop = 0;
        var marginLeft = 5;
        var marginTop = 1;
        var answerChar = '$';
        Console.SetCursorPosition((posLeft + marginLeft), (posTop + Console.WindowHeight - marginTop));
        Console.Write($"{answerChar} ");
        var answer = Console.ReadLine();
    }
}
