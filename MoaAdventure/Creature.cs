using System;
using System.Collections.Generic;
using System.Text;

namespace MoaAdventure
{
    class Creature
    {
        protected string _name;
        private int _speed;
        private string texture;
        private int PositionX;
        private int PositionY;

        void Attack() 
        { }
        void Move(string direction) { }
    }
}
