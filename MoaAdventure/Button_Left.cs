using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MoaAdventure
{
    class Button_Left: Entity
    {
        public static bool _activated;
        private int _Idletter;
        private double _positionX;
        private double _positionY;
        private List<Texture2D> _ButtonTexture;
        private SpriteBatch _spriteBatch;

        public Button_Left(Game game, int IdLetter, double positionX, double positionY) : base(game, IdLetter, positionX, positionY)
        {
            _activated = false;
            _Idletter = IdLetter;
            _positionX = PositionX;
            _positionY = PositionY;
            LoadContent();
        }

        public static void activateButton_Left()
        {
            if (_activated) _activated = false;
            else _activated = true;
        }

        protected override void LoadContent()
        {


            _ButtonTexture = new List<Texture2D>()
            { Game.Content.Load<Texture2D>("Sprites/Bouton")};

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
            _spriteBatch.Draw(_ButtonTexture[0], new Vector2((float)_positionX * 64, (float)_positionY * 64), null, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }

    }
}
