using System;
using System.Collections.Generic;
using System.Text;
using SharpDX.Direct3D11;

namespace MoaAdventure
{
    class Entity
    {
        protected int idLetter;
        protected string _name;
        protected int PositionX;
        protected int PositionY;
        protected string texture;

       public Entity(int IdLetter, int positionX, int positionY)
        {
            idLetter = IdLetter;
            PositionY = positionY;
            PositionX = positionX;
        }

        


    }
}
