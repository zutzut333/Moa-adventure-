using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace MoaAdventure
{
    class Button : Entity
    {
        private bool _activated;

        public Button(Game game, int IdLetter, int positionX, int positionY) : base(game, IdLetter, positionX, positionY)
        {
            _activated = false;
        }
    }
}
