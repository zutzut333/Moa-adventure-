using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace MoaAdventure
{
    class Monster : Creature
    {
        public Monster(Game game, int IdLetter, int positionX, int positionY) : base(game, IdLetter, positionX, positionY)
        {

            

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }



        //public string pathType;
        /*public void Move(string pathType) 
        {
            if (pathType == "vertical")
            {
                //if (direction = "up")
                // {//tant que pos y > pos finalup -> monte
                // direction = "down"}

                    //if (direction = "down")
                    // {//tant que pos y < pos finaldown -> descend
                    // direction = "up"}

            }
                else if (pathType == "random") 
            {
           //move(random)
            }
        }*/


    }
}
