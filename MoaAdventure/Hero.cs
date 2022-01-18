using System;
using System.Collections.Generic;
using System.Text;

namespace MoaAdventure
{
    class Hero : Creature
    {
        private int _lifeNumber;

       public Hero(int IdLetter, int positionX, int positionY) : base(IdLetter, positionX, positionY)
        {
            _lifeNumber = 3;

        }

    }
}
