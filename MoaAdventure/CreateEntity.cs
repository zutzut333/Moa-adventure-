using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MoaAdventure
{
    class CreateEntity
    {
        public CreateEntity(Game game ,int idletter, int column, int line,GameTime gameTime, int ActualLevel) 
        {

            switch (idletter)
            {
                case 1:
                    Spider spider = new Spider(game, idletter, column, line,1);
                    spider.DefineTexture("");
                    spider.DefineName("Spider");
                    spider.DefineSpeed(7);
                    spider.Update(gameTime);
                    game.Components.Add(spider);
                    break;

                case 2:
                    Button_Up button_Up = new Button_Up(game, idletter, column, line);
                    button_Up.DefineTexture("");
                    button_Up.DefineName("Button_Up");
                    game.Components.Add(button_Up);
                    break;

                case 3:
                    PickableItem carte = new PickableItem(game, idletter, column, line);
                    carte.DefineTexture("");
                    carte.DefineName("Carte");
                    game.Components.Add(carte);
                    break;

                case 4:
                    Door door = new Door(game, idletter, column, line);
                    door.DefineTexture("");
                    door.DefineName("Door");
                    game.Components.Add(door);
                    break;

                case 5:
                    PickableItem epee  = new PickableItem(game, idletter, column, line);
                    epee.DefineTexture("");
                    epee.DefineName("Epee");
                    game.Components.Add(epee);
                    break;

                case 6:
                    Hurted_Octopus hurt = new Hurted_Octopus(game, idletter, column, line,0);
                    hurt.DefineTexture("");
                    hurt.DefineName("Hurt");
                    hurt.DefineSpeed(7);
                    game.Components.Add(hurt);
                    break;

                case 7:
                    Movable_Wall movable_wall = new Movable_Wall(game, idletter, column, line, 0);
                    movable_wall.DefineTexture("");
                    movable_wall.DefineName("Movable Wall");
                    game.Components.Add(movable_wall);
                    break;


                case 8:
                    Hero hero = new Hero(game, idletter, column, line,1);
                    hero.DefineTexture("");
                    hero.DefineName("Hero");
                    hero.DefineSpeed(10);
                    game.Components.Add(hero);
                    break;

             

                case 11:
                    Knight knight = new Knight(game, idletter, column, line,1);
                    knight.DefineTexture("");
                    knight.DefineName("Knight");
                    knight.DefineSpeed(7);
                    knight.Update(gameTime);
                    game.Components.Add(knight);
                    break;

                case 12:
                    Button_Right button_right = new Button_Right(game, idletter, column, line);
                    button_right.DefineTexture("");
                    button_right.DefineName("Button_Right");
                    game.Components.Add(button_right);
                    break;

                case 13:
                    Trap mine = new Trap(game, idletter, column, line, "mine");
                    mine.DefineTexture("");
                    mine.DefineName("Mine");
                    game.Components.Add(mine);
                    break;

                case 14:
                    Button_Left button_left = new Button_Left(game, idletter, column, line);
                    button_left.DefineTexture("");
                    button_left.DefineName("Button_Left");
                    game.Components.Add(button_left);
                    break;


                case 15:
                    Octopus octopus = new Octopus(game, idletter, column, line,0);
                    octopus.DefineTexture("");
                    octopus.DefineName("Octopus");
                    octopus.DefineSpeed(7);
                    game.Components.Add(octopus);
                    break;

                case 18:
                    PickableItem ruby = new PickableItem(game, idletter, column, line);
                    ruby.DefineTexture("");
                    ruby.DefineName("Ruby");
                    game.Components.Add(ruby);
                    break;

                case 19:
                    Wall snow = new Wall(game, idletter, column, line, ActualLevel);
                    snow.DefineTexture("");
                    snow.DefineName("Snow");
                    game.Components.Add(snow);
                    break;


                case 20:
                    Trap trap = new Trap(game, idletter, column, line, "trap");
                    trap.DefineTexture("");
                    trap.DefineName("trap");
                    game.Components.Add(trap);
                    break;

                case 23:
                    Wall wood = new Wall(game, idletter, column, line, ActualLevel);
                    wood.DefineTexture("");
                    wood.DefineName("Wood");
                    game.Components.Add(wood);
                    break;

            }
        }
    }
}
