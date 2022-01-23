using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MoaAdventure
{
    class Trap : Entity
    {
        public string _type;
        private int _Idletter;
        private double _positionX;
        private double _positionY;
        private List<Texture2D> _TrapTexture;
        private SpriteBatch _spriteBatch;


        public Trap(Game game, int IdLetter, double positionX, double positionY,string type) : base(game, IdLetter, positionX, positionY)
        {
            _type = type;
            _Idletter = IdLetter;
            _positionX = PositionX;
            _positionY = PositionY;
            LoadContent();
        }

        protected override void LoadContent()
        {
            _TrapTexture = new List<Texture2D>()
            { Game.Content.Load<Texture2D>("Sprites/Mine"),
                Game.Content.Load<Texture2D>("Sprites/trou de glace")};

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
            _spriteBatch.Draw(_TrapTexture[0], new Vector2((float)_positionX * 64, (float)_positionY * 64), null, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }

    }
}
