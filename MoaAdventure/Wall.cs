using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MoaAdventure
{

    class Wall : Entity
    {
        private int _Idletter;
        private int _positionX;
        private int _positionY;
        private int _actualLevel;
        private List<Texture2D> _WallTexture;
        private SpriteBatch _spriteBatch;
        
        public Wall(Game game, int IdLetter, int positionX, int positionY,int ActualLevel) : base(game, IdLetter, positionX, positionY)
        {
            _Idletter = IdLetter;
            _positionX = PositionX;
            _positionY = PositionY;
            _actualLevel = ActualLevel;
            LoadContent();
        }

        protected override void LoadContent()
        {
            _WallTexture = new List<Texture2D>()
            {  Game.Content.Load<Texture2D>("Sprites/Bois"),
                Game.Content.Load<Texture2D>("Sprites/Bois"),
                Game.Content.Load < Texture2D > ("Sprites/Glace"),
                Game.Content.Load < Texture2D > ("Sprites/Brique"),
                Game.Content.Load < Texture2D > ("Sprites/Beton")};

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
            _spriteBatch.Draw(_WallTexture[_actualLevel], new Vector2(_positionX * 64, _positionY * 64), null, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }

    }
}
