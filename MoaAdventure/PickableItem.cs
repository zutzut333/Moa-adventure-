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
        private int _positionX;
        private int _positionY;
        private List<Texture2D> _ItemsTexture;
        private SpriteBatch _spriteBatch;

        public PickableItem(Game game, int IdLetter, int positionX, int positionY) : base(game, IdLetter, positionX, positionY)
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
            _spriteBatch.Draw(_ItemsTexture[0], new Vector2(_positionX * 64, _positionY * 64), null, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }

    }
}
