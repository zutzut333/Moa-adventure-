using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace MoaAdventure
{
    class PickableItem : Entity
    {
        private bool _taken;
        public void TakeItem() 
        { }

        public PickableItem(Game game, int IdLetter, int positionX, int positionY) : base(game, IdLetter, positionX, positionY)
        {

        }

    }
}
