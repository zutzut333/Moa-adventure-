﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoaAdventure
{
    class Creature : Entity
    {
        
        private int _speed;

        public Creature(int IdLetter, int positionX, int positionY) : base(IdLetter, positionX, positionY)
        {

        }

        void Attack() 
        { }
        void Move(string direction) { }
    }
}
