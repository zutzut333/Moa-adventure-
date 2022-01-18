using System;
using System.Collections.Generic;
using System.Text;

namespace MoaAdventure
{
    class Monster : Creature
    {
        public Monster(int IdLetter, int positionX, int positionY) : base(IdLetter, positionX, positionY)
        {

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
