namespace Uiorzo
{
    public class Uiorzo
    {
        private int _windowWidth;
        private int _windowHeight;

        public Uiorzo()
        {
            _windowWidth = Console.WindowWidth;
            _windowHeight = Console.WindowHeight;
        }

        public void Draw(char c)
        {
            DrawCorners(c);

        }
        private void DrawCorners(char c)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(c);

            Console.SetCursorPosition(0 + _windowWidth - 1, 0);
            Console.Write(c);

            Console.SetCursorPosition(0, 0 + _windowHeight - 1);
            Console.Write(c);

            Console.SetCursorPosition(0 + _windowWidth - 1, 0 + _windowHeight - 1);
            Console.Write(c);
        }

        public string? DrawInput()
        {
            Draw('#'); 
            var posLeft = 0;
            var posTop = 0;
            var marginLeft = 5;
            var marginTop = 1;
            var answerChar = '$';
            Console.SetCursorPosition((posLeft + marginLeft), (posTop + _windowHeight - marginTop));
            Console.Write($"{answerChar} ");
            string? answer = Console.ReadLine();
            return answer;
        }
    }
}