using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace MoaAdventure
{
    class CreateEntity
    {
        public CreateEntity(Game game ,int idletter, int column, int line) 
        {

            switch (idletter)
            {
                case 1:
                    Monster spider = new Monster(game, idletter, column, line);
                    spider.DefineTexture("");
                    spider.DefineName("Spider");
                    spider.DefineSpeed(1);
                    
                    break;

                case 2:
                    Button button = new Button(game, idletter, column, line);
                    button.DefineTexture("");
                    button.DefineName("Button");
                    break;

                case 3:
                    PickableItem carte = new PickableItem(game, idletter, column, line);
                    carte.DefineTexture("");
                    carte.DefineName("Carte");
                    break;

                case 4:
                    Door door = new Door(game, idletter, column, line);
                    door.DefineTexture("");
                    door.DefineName("Door");
                    break;

                case 5:
                    PickableItem epee  = new PickableItem(game, idletter, column, line);
                    epee.DefineTexture("");
                    epee.DefineName("Epee");
                    break;

                case 8:
                    Hero hero = new Hero(game, idletter, column, line);
                    hero.DefineTexture("");
                    hero.DefineName("Hero");
                    hero.DefineSpeed(2);
                    break;

                case 11:
                    Monster knight = new Monster(game, idletter, column, line);
                    knight.DefineTexture("");
                    knight.DefineName("Knight");
                    knight.DefineSpeed(2);
                    break;

                case 13:
                    Trap mine = new Trap(game, idletter, column, line, "mine");
                    mine.DefineTexture("");
                    mine.DefineName("Mine");
                    break;

                case 15:
                    Monster octopus = new Monster(game, idletter, column, line);
                    octopus.DefineTexture("");
                    octopus.DefineName("Octopus");
                    octopus.DefineSpeed(1);
                    break;

                case 18:
                    PickableItem ruby = new PickableItem(game, idletter, column, line);
                    ruby.DefineTexture("");
                    ruby.DefineName("Ruby");
                    break;

                case 19:
                    Wall snow = new Wall(game, idletter, column, line);
                    snow.DefineTexture("");
                    snow.DefineName("Snow");
                    break;


                case 20:
                    Trap trap = new Trap(game, idletter, column, line, "trap");
                    trap.DefineTexture("");
                    trap.DefineName("trap");
                    break;

                case 23:
                    Wall wood = new Wall(game, idletter, column, line);
                    wood.DefineTexture("");
                    wood.DefineName("Wood");
                    break;

            }
        }
    }
}
