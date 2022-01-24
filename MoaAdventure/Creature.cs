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
            double basicPositionX = positionX;
            double basicPositionY = positionY;
            if (this.idLetter == 8||this.idLetter==11) time = gameTime.ElapsedGameTime.TotalSeconds;
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

                foreach (Entity entity in Game.Components)
                {
                if (Game.Components.IndexOf(this) != Game.Components.IndexOf(entity)) 
                {
                    double distance;
                    distance = Math.Sqrt(Math.Pow(MathHelper.Distance((float)positionX, (float)entity.positionX), 2) + Math.Pow(MathHelper.Distance((float)positionY, (float)entity.positionY), 2));
                    if (distance < 1 && distance != 0)
                    {
                        if (entity.IdLetter == 23||entity.IdLetter==4) 
                        {
                            positionY = basicPositionY;
                            positionX = basicPositionX;
                        }
                        if (this.idLetter == 8 && (entity.IdLetter == 1||entity.IdLetter==11||entity.IdLetter==13|| entity.IdLetter == 20))Hero.Die();
                    }
                }


            }
                return (positionX,positionY);
                
                
           
            }
           
               
    }
}
