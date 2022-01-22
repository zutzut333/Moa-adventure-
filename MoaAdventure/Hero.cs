using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MoaAdventure
{
    class Hero : Creature
    {
        private int _Idletter;
        private int _positionX;
        private int _positionY;
        private List<Texture2D> _HeroTexture;
        private SpriteBatch _spriteBatch;
        private int _lifeNumber;

       public Hero(Game game, int IdLetter, int positionX, int positionY) : base(game, IdLetter, positionX, positionY)
        {
            _Idletter = IdLetter;
            _positionX = PositionX;
            _positionY = PositionY;
            LoadContent();
            _lifeNumber = 3;
        }

        protected override void LoadContent()
        {


            _HeroTexture = new List<Texture2D>()
           {   Game.Content.Load < Texture2D > ("Sprites/Perso haut"),
                Game.Content.Load<Texture2D>("Sprites/Perso face"),
                Game.Content.Load<Texture2D>("Sprites/Perso gauche"),
                Game.Content.Load<Texture2D>("Sprites/Perso droite") };

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
            _spriteBatch.Draw(_HeroTexture[0], new Vector2(_positionX * 64, _positionY * 64), null, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }

    }
}
