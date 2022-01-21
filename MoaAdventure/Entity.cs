using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using SharpDX.Direct3D11;

namespace MoaAdventure
{
    class Entity : DrawableGameComponent
    {
        protected int idLetter;
        protected string _name;
        protected int PositionX;
        protected int PositionY;
        protected string _texture;

        public Entity(Game game, int IdLetter, int positionX, int positionY) : base(game)
        {
            idLetter = IdLetter;
            PositionY = positionY;
            PositionX = positionX;
        }

        public void DefineTexture(string texture)
        {
            _texture = texture;
        }

        public void DefineName(string name)
        {
            _name = name;
        }
    }
}
