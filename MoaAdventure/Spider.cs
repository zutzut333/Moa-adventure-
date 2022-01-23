using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace MoaAdventure
{
    class Spider : Creature
    {
        private int _Idletter;
        private double _positionX;
        private double _positionY;
        private List<Texture2D> _spiderPathList;
        private SpriteBatch _spriteBatch;
        private int _textureSense;
        int count = 0;
        int randomDirection;
        string direction;
        public Spider(Game game, int IdLetter, double positionX, double positionY,int textureSense) : base(game, IdLetter, positionX, positionY,textureSense)
        {
            _Idletter = IdLetter;
            _positionX = PositionX;
            _positionY = PositionY;
            _textureSense = textureSense;
            LoadContent();
        }

        protected override void LoadContent()
        {


            _spiderPathList = new List<Texture2D>()
            { Game.Content.Load<Texture2D>("Sprites/Spider up"),
                Game.Content.Load<Texture2D>("Sprites/Spider low"),
                Game.Content.Load<Texture2D>("Sprites/Spider left"),
                Game.Content.Load<Texture2D>("Sprites/Spider right") };

            _spriteBatch = new SpriteBatch(GraphicsDevice);

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {

            
            List<string> newDirection;
            newDirection = new List<string>() { "up", "down", "left", "right" };
            Random rand = new Random();
            if (count == 0)
            {
                randomDirection = rand.Next(0, 4);
                direction = newDirection[randomDirection];
            }
            if (direction == "up" || direction == "down") 
            { 
                _positionX = this.Move("down", _positionX, _positionY, gameTime).Item1;
                if (direction == "up") _textureSense = 0;
                else _textureSense = 1;
            }
            else if(direction == "left" || direction == "right")
            {
                this._positionY = this.Move("down", _positionX, _positionY, gameTime).Item2;
                if (direction == "left") _textureSense = 2;
                else _textureSense = 3;
            }
            if (count != 20) count++;
            else count = 0;
            
            
            Draw(gameTime);
            base.Update(gameTime);

        }

        public override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();
            _spriteBatch.Draw(_spiderPathList[_textureSense], new Vector2((float)_positionX * 64, (float)_positionY * 64), null, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }



       

    }
}
