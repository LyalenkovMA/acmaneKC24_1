using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acmaneKC24_1
{
    public class World
    {
        private char[,] _map;
        private char _symbolWall;
        private char _symbolMeal;

        public World()
        {
            _symbolWall = '#';
            _symbolMeal = '.';
            _map = GetMap("map.txt");
        }

        public bool IsWall(Vector vector)
        {
            return _map[vector.X, vector.Y] == _symbolWall;
        }

        public bool IsMeal(Vector vector)
        {
            return _map[vector.X, vector.Y] == _symbolMeal;
        }

        public void Draw()
        {
            for (int y = 0; y < _map.GetLength(0); y++)
            {
                for(int x = 0; x< _map.GetLength(1);x++)
                    Console.Write(_map[y,x]);

                Console.WriteLine();
            }
        }

        private char[,] GetMap(string path)
        {
            string[] strings = File.ReadAllLines(path);
            char[,] map = new char[strings.Length, GetMaxOfLine(strings)];

            for (int y = 0; y < map.GetLength(0); y++)
                for (int x = 0; x < map.GetLength(1); x++)
                    map[x,y] = strings[y][x];

            return map;
        }

        private int GetMaxOfLine(string[] strings)
        {
            int maxOfLine = 0;

            foreach (string line in strings)
                if (line.Length > maxOfLine)
                    maxOfLine = line.Length;

            return maxOfLine;
        }
    }
}
