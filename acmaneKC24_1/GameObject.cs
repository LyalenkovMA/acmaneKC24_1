using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acmaneKC24_1
{
    public abstract class GameObject
    {
        protected const int KeyDirectionUp = 1;
        protected const int KeyDirectionDown = 2;
        protected const int KeyDirectionLeft = 3;
        protected const int KeyDirectionRigth = 4;

        private World _world;

        public GameObject(Vector position, char symbol, World world)
        {
            Position = position;
            Symbol = symbol;
            _world = world;
        }

        public Vector Position { get; private set; }

        public char Symbol { get; private set; }

        public abstract void Update();

        public void Draw()
        {
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.Write(Symbol);
        }

        protected void ToChangePosition(Vector move)
        {
            Vector oldPosition = Position;
            Position += move;

            if (_world.IsWall(Position))
                Position = oldPosition;
        }
    }
}
