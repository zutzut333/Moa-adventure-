using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace MoaAdventure
{
    class PickableItem : Entity
    {
        private bool _taken;
        private int _Idletter;
        private double _positionX;
        private double _positionY;
        private List<Texture2D> _ItemsTexture;
        private SpriteBatch _spriteBatch;

        public PickableItem(Game game, int IdLetter, double positionX, double positionY) : base(game, IdLetter, positionX, positionY)
        {
            _Idletter = IdLetter;
            _positionX = PositionX;
            _positionY = PositionY;
            LoadContent();
        }
        public void TakeItem()
        { }

        protected override void LoadContent()
        {
            _ItemsTexture = new List<Texture2D>()
            { Game.Content.Load<Texture2D>("Sprites/Carte"),
                Game.Content.Load<Texture2D>("Sprites/épée magique"),
                Game.Content.Load<Texture2D>("Sprites/Pierre Magique")};

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
            if(_Idletter==3)
                _spriteBatch.Draw(_ItemsTexture[0], new Vector2((float)_positionX * 64, (float)_positionY * 64), null, Color.White);
            else if(_Idletter == 5)
                _spriteBatch.Draw(_ItemsTexture[1], new Vector2((float)_positionX * 64, (float)_positionY * 64), null, Color.White);
            else if (_Idletter == 18)
                _spriteBatch.Draw(_ItemsTexture[2], new Vector2((float)_positionX * 64, (float)_positionY * 64), null, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }

    }
}
