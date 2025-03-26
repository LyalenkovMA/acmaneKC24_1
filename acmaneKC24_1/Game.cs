using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace acmaneKC24_1
{
    public class Game
    {
        private World _world;
        Player _player;

        public Game()
        {
            _world = new World();
            _player = new Player(new Vector(2,2),_world);
        }

        public void Start()
        {
            Task.Run(()=>
            {
                while (_player.IsLive)
                {
                    _player.Controler();
                }
            });

            Task.Run(() =>
            {
                while (_player.IsLive)
                {
                    Update();
                    Thread.Sleep(500);
                }
            });

            while (_player.IsLive)
            {
                Draw();
                Thread.Sleep(500);
            }
        }

        private void Update()
        {
            _player.Update();
        }

        private void Draw()
        {
            Console.Clear();

            _world.Draw();
            _player.Draw();
        }
    }
}
