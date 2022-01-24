using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MoaAdventure
{

    class Movable_Wall_Right : Entity
    {
        private int _Idletter;
        private double _positionX;
        private double _positionY;
        private int _actualLevel;
        private List<Texture2D> _WallTexture;
        private SpriteBatch _spriteBatch;

        public Movable_Wall_Right(Game game, int IdLetter, double positionX, double positionY, int ActualLevel) : base(game, IdLetter, positionX, positionY)
        {
            _Idletter = IdLetter;
            _positionX = PositionX;
            _positionY = PositionY;
            _actualLevel = ActualLevel;
            LoadContent();
        }

        public void moveRight()
        {
            positionX = positionX + 128;
        }

        public void moveLeft()
        {
            positionX = positionX - 128;
        }

        protected override void LoadContent()
        {
            _WallTexture = new List<Texture2D>()
            { Game.Content.Load < Texture2D > ("Sprites/Glace"), };

            _spriteBatch = new SpriteBatch(GraphicsDevice);

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            if ((positionX == 1 || positionX == 2) && positionY==7)
            {
                if (Button_Up._activated == true)
                {
                    moveRight();
                    Button_Up._activated = false;
                }
            }
            else moveLeft();
            if ((positionX == 13 || positionX == 14) && positionY == 6)
            {
                if ((Button_Left._activated == true && Button_Right._activated == true)|| (Button_Left._activated == false && Button_Right._activated == false))
                {
                    moveRight();
                    Button_Up._activated = false;
                }
            }
            else moveLeft();

            Draw(gameTime);
            base.Update(gameTime);

        }

        public override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();
            _spriteBatch.Draw(_WallTexture[0], new Vector2((float)_positionX * 64, (float)_positionY * 64), null, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }

    }
}
