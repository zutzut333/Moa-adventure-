using System;
using System.Collections.Generic;
using System.Text;

namespace MoaAdventure
{
    class Trap : Entity
    {
        public string _type;

        public Trap(int IdLetter, int positionX, int positionY, string type) : base(IdLetter, positionX, positionY)
        {
            _type = type;
        }
    }
}
