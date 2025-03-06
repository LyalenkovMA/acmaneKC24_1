using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acmaneKC24_1
{
    public class Game
    {
        private World _world;

        public Game()
        {
            _world = new World();
        }

        public void Start()
        {
            _world.Draw();
        }
    }
}
