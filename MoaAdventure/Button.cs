using System;
using System.Collections.Generic;
using System.Text;

namespace MoaAdventure
{
    class Button : Entity
    {
        private bool _activated;

        public Button(int IdLetter, int positionX, int positionY) : base(IdLetter, positionX, positionY)
        {

        }
    }
}
