using System;
using System.IO;

namespace MoaAdventure
{
    public class LevelLoader
    {
        private Map _map;

        public LevelLoader(string levelFilename)
        {
            ParseContent(levelFilename);
        }

        private void ParseContent(string levelFilename)
        {
            string[] fileLines = File.ReadAllLines(levelFilename);
            int width = fileLines[0].Length;
            int height = fileLines.Length;

            int[,] tileMap = new int[width, height];
            for (int line = 0; line < height; line++)
            {
                string currentFileLine = fileLines[line];
                for (int column = 0; column < width; column++)
                {
                    char item = currentFileLine[column];
                    if (item >= 'A' && item <= 'Z')
                    {
                        tileMap[column, line] = item - '@';
                    }
                }
            }

            _map = new Map(width, height, tileMap);
        }

        public Map map
        {
            get { return _map; }
        }
    }
}
