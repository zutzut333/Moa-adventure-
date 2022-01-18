using System;
using System.Collections.Generic;
using System.Text;

namespace MoaAdventure
{
    class Trap : Entity
    {
        private string _type;

        Trap(int IdLetter, int positionX, int positionY) : base(IdLetter, positionX, positionY)
        {

        }
    }
}
