using System;
using System.Collections.Generic;
using System.Text;

namespace MoaAdventure
{
    class PickableItem : Entity
    {
        private bool _taken;
        public void TakeItem() 
        { }

        public PickableItem(int IdLetter, int positionX, int positionY) : base(IdLetter, positionX, positionY)
        {

        }

    }
}
