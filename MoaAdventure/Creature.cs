using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace MoaAdventure
{
    class Creature : Entity
    {
        
        private int _speed;

        public Creature(Game game, int IdLetter, int positionX, int positionY) : base(game, IdLetter, positionX, positionY)
        {

        }

        public void DefineSpeed(int speed)
        {
            _speed = speed;
        }

        void Attack() 
        { }
        void Move(string direction) { }
    }
}
