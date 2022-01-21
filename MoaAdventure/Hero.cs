using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace MoaAdventure
{
    class Hero : Creature
    {
        private int _lifeNumber;

       public Hero(Game game, int IdLetter, int positionX, int positionY) : base(game, IdLetter, positionX, positionY)
        {
            _lifeNumber = 3;

        }

    }
}
