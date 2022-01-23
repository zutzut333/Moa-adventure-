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
            double time;


            if (this.idLetter == 8) time = gameTime.ElapsedGameTime.TotalSeconds;
            else time = 0.02;
            
                
                
                    switch (direction)
                    {
                        case "up":
                            positionY -= Speed * time;
                            
                                break;
                        case "down":
                            positionY += Speed * time;
                            
                                break;
                        case "left":
                            positionX -= Speed * time;
                            
                                break;
                        case "right":
                            positionX += Speed * time;
                            
                                break;
                        
                    }
                
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
