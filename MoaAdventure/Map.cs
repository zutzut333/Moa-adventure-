using System;

namespace MoaAdventure
{
    public class Map
    {
        private int _width;
        private int _height;
        private int[,] _map;

        public Map(int width, int height, int[,] tileIds)
        {
            _width = width;
            _height = height;
            _map = tileIds;
        }

        public int Height
        {
            get { return _height; }
        }

        public int Width
        {
            get { return _width; }
        }

        public int TileIdAt(int x, int y)
        {
            return _map[x, y];
        }

       /* public bool HasWallAt(int x, int y)
        {
            return _map[x, y] != 0;
        }*/
    }
}
