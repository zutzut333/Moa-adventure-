using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using static MoaAdventure.Game1;

namespace MoaAdventure
{
    class Creature : Entity
    {
        private int textureSense;
        private int _speed;

        public Creature(Game game, int IdLetter, double positionX, double positionY,int textureSense) : base(game, IdLetter, positionX, positionY)
        {

        }

        public void DefineSpeed(int speed)
        {
            _speed = speed;
        }

        public int Speed
        {
            get { return _speed; }
        }

        void Attack() 
        { }

        
            public (double, double) Move(string direction,double positionX, double positionY,GameTime gameTime) 
            {
            List<string> newDirection;
            newDirection = new List<string>() { "up", "down", "left", "right" };
            Random rand = new Random();
            double time = gameTime.ElapsedGameTime.TotalSeconds;
            bool isSpider;
                do
                {
                isSpider = false;
                    switch (direction)
                    {
                        case "up":
                            positionY -= Speed * time;
                            this.textureSense = 0;
                                break;
                        case "down":
                            positionY += Speed * time;
                            this.textureSense = 1;
                                break;
                        case "left":
                            positionX -= Speed * time;
                            this.textureSense = 2;
                                break;
                        case "right":
                            positionX += Speed * time;
                            this.textureSense = 3;
                                break;
                        case "random":
                        
                            int randomDirection=rand.Next(0, 4);
                            direction = newDirection[randomDirection];
                            time = 0.02;
                            isSpider = true;
                                break;
                    }
                } while (isSpider == true);
                if (positionX * 64 > _graphics.PreferredBackBufferWidth - 64)
                        positionX = (_graphics.PreferredBackBufferWidth - 64) / 64;
                else if (positionX < 0)
                        positionX = 0;

                if (positionY * 64 > _graphics.PreferredBackBufferHeight - 64)
                    positionY = (_graphics.PreferredBackBufferHeight - 64) / 64;
                else if (positionY < 0)positionY = 0;
                return (positionX,positionY);
                
                
           
            }
           
               
    }
}
