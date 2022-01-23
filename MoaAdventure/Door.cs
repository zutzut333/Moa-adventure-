using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MoaAdventure
{
    class Door : Entity
    {
        private int _Idletter;
        private double _positionX;
        private double _positionY;
        private List<Texture2D> _porteMagique;
        private SpriteBatch _spriteBatch;

        public Door(Game game, int IdLetter, double positionX, double positionY) : base(game, IdLetter, positionX, positionY)
        {
            _Idletter = IdLetter;
            _positionX = PositionX;
            _positionY = PositionY;
            LoadContent();
        }

        public void changeLevel() { }

        protected override void LoadContent()
        {


            _porteMagique = new List<Texture2D>()
            { Game.Content.Load<Texture2D>("Sprites/porte Magique")};

            _spriteBatch = new SpriteBatch(GraphicsDevice);

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {

            Draw(gameTime);
            base.Update(gameTime);

        }

        public override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();
            _spriteBatch.Draw(_porteMagique[0], new Vector2((float)_positionX * 64, (float)_positionY * 64), null, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
