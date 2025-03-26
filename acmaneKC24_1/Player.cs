using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acmaneKC24_1
{
    public class Player : GameObject
    {
        private int _direction;

        public Player(Vector position, World world): base(position, '@',world)
        {
            _direction = KeyDirectionLeft;
            CountLive = 3;
        }

        public int CountLive { get; private set; }

        public bool IsLive => CountLive > 0;

        public override void Update()
        {
            switch (_direction)
            {
                case KeyDirectionUp:
                    ToChangePosition(new Vector(0, -1));
                    break;
                case KeyDirectionDown:
                    ToChangePosition(new Vector(0, 1));
                    break;
                case KeyDirectionLeft:
                    ToChangePosition(new Vector(-1,0));
                    break;
                case KeyDirectionRigth:
                    ToChangePosition(new Vector(1,0));
                    break;
            }
        }

        public void Controler()
        {
            const ConsoleKey KeyUp = ConsoleKey.UpArrow;
            const ConsoleKey KeyDown = ConsoleKey.DownArrow;
            const ConsoleKey KeyLeft = ConsoleKey.LeftArrow;
            const ConsoleKey KeyRigth = ConsoleKey.RightArrow;

            ConsoleKey key = Console.ReadKey().Key;

            switch (key)
            {
                case KeyUp:
                    _direction = KeyDirectionUp;
                    break;
                case KeyDown:
                    _direction = KeyDirectionDown;
                    break;
                case KeyLeft:
                    _direction = KeyDirectionLeft;
                    break;
                case KeyRigth:
                    _direction = KeyDirectionRigth;
                    break;
            }
        }
    }
}
