using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acmaneKC24_1
{
    public abstract class GameObject
    {
        public GameObject(Vector position, char symbol)
        {
            Position = position;
            Symbol = symbol;
        }

        public Vector Position { get; private set; }

        public char Symbol { get; private set; }

        public abstract void Update();

        public void Draw()
        {
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.Write(Symbol);
        }

        protected void ToChangePosition(Vector move) => Position += move;
    }
}
