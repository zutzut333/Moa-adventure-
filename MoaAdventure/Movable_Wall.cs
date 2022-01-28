using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MoaAdventure
{

    class Movable_Wall : Entity
    {
        private int _Idletter;
        private double _positionX;
        private double _positionY;
        private int _actualLevel;
        private List<Texture2D> _WallTexture;
        private SpriteBatch _spriteBatch;
        bool positionLeft;
        Game game;

        public Movable_Wall(Game game, int IdLetter, double positionX, double positionY, int ActualLevel) : base(game, IdLetter, positionX, positionY)
        {
            _Idletter = IdLetter;
            _positionX = PositionX;
            _positionY = PositionY;
            _actualLevel = ActualLevel;
            if ((positionX == 0 || positionX == 1) && positionY == 6) positionLeft = true;
            else if ((positionX == 12 || positionX == 13) && positionY == 5) positionLeft = false;
            
                LoadContent();
        }

        public void moveRight()
        {
            foreach (Entity entity in Game.Components)
            {
                if (((positionX == 0 || positionX == 1) && positionY == 6) || ((positionX == 12 || positionX == 13) && positionY == 5)) this.positionX = positionX + 3;


            }
        }

        public void moveLeft()
        {
            foreach (Entity entity in Game.Components)
            {
                if (((positionX == 0 || positionX == 1) && positionY == 6) || ((positionX == 12 || positionX == 13) && positionY == 5)) this.positionX = positionX - 3;


            }
            
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
            if ((positionX == 0 || positionX == 1) && positionY==6 )
            {
                if (Button_Up._activated == true && positionLeft)
                {
                    moveRight();
                    Button_Up._activated = false;
                    positionLeft = false;
                }
                else if (Button_Up._activated == false && !positionLeft) moveLeft();
            }
            
            if ((positionX == 12 || positionX == 13) && positionY == 5 )
            {
                if (((Button_Left._activated == true && Button_Right._activated == true)|| (Button_Left._activated == false && Button_Right._activated == false)) && !positionLeft)
                {
                    moveRight();
                    Button_Up._activated = false;
                    positionLeft = true;
                }
                else if(((Button_Left._activated == true && Button_Right._activated == true) || (Button_Left._activated == false && Button_Right._activated == false)) && positionLeft) moveLeft();
            }
            

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
