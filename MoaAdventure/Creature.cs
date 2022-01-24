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
        private Microsoft.Xna.Framework.GameComponent _entity; 

        public Creature(Game game, int IdLetter, double positionX, double positionY,int textureSense) : base(game, IdLetter, positionX, positionY)
        {

        }

        public void supressItem()
        {
            Game.Components.RemoveAt(Game.Components.IndexOf(_entity));
            _entity = null;
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
                //collision avec les murs de la fenêtre
                if (positionX * 64 > _graphics.PreferredBackBufferWidth - 64)
                        positionX = (_graphics.PreferredBackBufferWidth - 64) / 64;
                else if (positionX < 0)
                        positionX = 0;

                if (positionY * 64 > _graphics.PreferredBackBufferHeight - 64)
                    positionY = (_graphics.PreferredBackBufferHeight - 64) / 64;
                else if (positionY < 0)positionY = 0;


                //je parcours chaque entité stockées dans game.component
                foreach (Entity entity in Game.Components)
                {
                //si l'entité en cours de move n'est pas l'entité dans le foreach
                if (Game.Components.IndexOf(this) != Game.Components.IndexOf(entity)) 
                {
                    //je calcule la distance entre les deux
                    double distance;
                    //pythagore
                    distance = Math.Sqrt(Math.Pow(MathHelper.Distance((float)positionX, (float)entity.positionX), 2) + Math.Pow(MathHelper.Distance((float)positionY, (float)entity.positionY), 2));
                    //si la distance vaut moins de 1
                    if (distance < 0.8 && distance != 0)
                    {
                        //si c'est un mur ou une porte
                        if (entity.IdLetter == 23  || entity.IdLetter == 19)
                        {
                            //la position revient à sa situation d'entrée dans move'

                            positionY = basicPositionY;
                            positionX = basicPositionX;
                        }

                        if(entity.IdLetter == 4 &&this.idLetter==8)
                        {
                            // si hero + item passe sinon comme au dessus
                            if(Door._lock == false)
                            {
                                Door.changeLevel();
                                break;
                            }
                            else
                            {
                                positionY = basicPositionY;
                                positionX = basicPositionX;
                            }


                        }

                        if( this.idLetter==8&&(entity.IdLetter == 3 || entity.IdLetter == 5 || entity.IdLetter == 18))
                        {
                            Door.doorUnlocked();
                            _entity = entity;

                        }
                        

                        //si c'est le hero qui move et si c'est (un monstre ou un trap)
                        if (
                            (this.idLetter == 8 && 
                                (entity.IdLetter == 1 || entity.IdLetter == 11 || entity.IdLetter == 13 || entity.IdLetter == 20))||
                            (entity.IdLetter == 8 && (this.idLetter == 1 || this.idLetter == 11 || this.idLetter == 13 || this.idLetter == 20)))
                        {
                            Hero.Die(Game, entity.IdLetter, this);
                            break;
                        }
                    }
                }

                
            }

            if (_entity != null) {
                supressItem();
                    };

            this.positionX = positionX;
            this.positionY = positionY;
                return (positionX,positionY);
                
                
           
            }
           
               
    }
}
