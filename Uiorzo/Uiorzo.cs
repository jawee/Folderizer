﻿namespace Uiorzo
{
    public class Uiorzo
    {
        private int _windowWidth;
        private int _windowHeight;
        private readonly List<IComponent> _components;

        public Uiorzo()
        {
            _windowWidth = Console.WindowWidth;
            _windowHeight = Console.WindowHeight;
            _components = new List<IComponent>();
        }

        public void AddComponent(IComponent component)
        {
            _components.Add(component);
        }

        public void DrawGui()
        {
            foreach(var component in _components)
            {
                component.Draw();
            }

        }

        // public void Draw(char c)
        // {
        //     DrawCorners(c);
        //
        // }
        // private void DrawCorners(char c)
        // {
        //     Console.SetCursorPosition(0, 0);
        //     Console.Write(c);
        //
        //     Console.SetCursorPosition(0 + _windowWidth - 1, 0);
        //     Console.Write(c);
        //
        //     Console.SetCursorPosition(0, 0 + _windowHeight - 1);
        //     Console.Write(c);
        //
        //     Console.SetCursorPosition(0 + _windowWidth - 1, 0 + _windowHeight - 1);
        //     Console.Write(c);
        // }
    }
}
