using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace MoaAdventure
{
    class Trap : Entity
    {
        public string _type;

        public Trap(Game game, int IdLetter, int positionX, int positionY,string type) : base(game, IdLetter, positionX, positionY)
        {
            _type = type;
        }
    }
}
