using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace MoaAdventure
{
    class Knight : Creature
    {
        private int _Idletter;
        private double _positionX;
        private double _positionY;
        private List<Texture2D> _knightPathList;
        private SpriteBatch _spriteBatch;
        private bool init = true;
        bool wayDown;
        int _textureSense;

        public Knight(Game game, int IdLetter, double positionX, double positionY,int textureSense) : base(game, IdLetter, positionX, positionY,textureSense)
        {
            _Idletter = IdLetter;
            _positionX = PositionX;
            _positionY = PositionY;
            LoadContent();
            _textureSense = textureSense;
        }

        protected override void LoadContent()
        {


            _knightPathList = new List<Texture2D>()
            { Game.Content.Load<Texture2D>("Sprites/Chevalier bas"),
                Game.Content.Load<Texture2D>("Sprites/Chevalier haut")};

            _spriteBatch = new SpriteBatch(GraphicsDevice);

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            
            
            if(init)
            {
               wayDown = true;
               init = false;
            } 
            if (wayDown) 
            {
                _textureSense = 0;
                if (_positionY>=9) wayDown = false;
                else this._positionY = this.Move("down", _positionX, _positionY, gameTime).Item2;
            }
            else 
            {
                _textureSense = 1;
                if (_positionY <= 0) wayDown = true;
                else this._positionY = this.Move("up", _positionX, _positionY, gameTime).Item2;
            }

            
            
                    
                
            
                

            Draw(gameTime);
            base.Update(gameTime);

        }

        public override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();
            _spriteBatch.Draw(_knightPathList[_textureSense], new Vector2((float)_positionX * 64, (float)_positionY * 64), null, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }



       


    }
}
