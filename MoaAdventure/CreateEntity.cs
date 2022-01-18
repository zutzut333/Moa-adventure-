using System;
using System.Collections.Generic;
using System.Text;

namespace MoaAdventure
{
    class CreateEntity
    {
        public CreateEntity(int idletter, int column, int line)
        {

            switch (idletter)
            {
                case 1:
                    Monster monster = new Monster(idletter, column, line);
                    monster.DefineTexture("");
                    monster.DefineName("Spider");

                    break;
                case 2:
                    Button button = new Button(idletter, column, line);
                    button.DefineTexture("");
                    button.DefineName("Button");
                    break;

                case 3:
                    PickableItem carte = new PickableItem(idletter, column, line);
                    carte.DefineTexture("");
                    carte.DefineName("Carte");
                    break;

                case 4:
                    Door door = new Door(idletter, column, line);
                    door.DefineTexture("");
                    door.DefineName("Door");
                    break;

                case 5:
                    PickableItem epee  = new PickableItem(idletter, column, line);
                    epee.DefineTexture("");
                    epee.DefineName("Epee");

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
