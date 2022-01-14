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

        Entity(int IdLetter, int positionX, int positionY)
        {
            idLetter = IdLetter;
            PositionY = positionY;
            PositionX = positionX;
            DefineTile(idLetter);
        }

        private void DefineTile(int idletter)
        {

            switch (idletter)
            {
                case 1: 
                


                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 8:

                    break;
                case 11:

                    break;
                case 13:

                    break;
                case 15:

                    break;
                case 18:

                    break;
                case 19:

                    break;
                case 20:

                    break;
                case 23:

                    break;



            }
        }




    }
}
