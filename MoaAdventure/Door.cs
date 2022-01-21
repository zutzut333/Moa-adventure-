using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace MoaAdventure
{
    class Door : Entity
    {
        public void changeLevel() { }


        public Door(Game game, int IdLetter, int positionX, int positionY) : base(game, IdLetter, positionX, positionY)
        {

        }

    }
}
