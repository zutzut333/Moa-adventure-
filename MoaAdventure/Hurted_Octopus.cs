using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace MoaAdventure
{
    class Hurted_Octopus : Creature
    {
        private int _Idletter;
        private double _positionX;
        private double _positionY;
        private List<Texture2D> _HurtTexture;
        private SpriteBatch _spriteBatch;

        public Hurted_Octopus(Game game, int IdLetter, double positionX, double positionY,int textureSense) : base(game, IdLetter, positionX, positionY,textureSense)
        {
            _Idletter = IdLetter;
            _positionX = PositionX;
            _positionY = PositionY;
            LoadContent();
        }

        protected override void LoadContent()
        {
                _HurtTexture = new List<Texture2D>()
            { Game.Content.Load<Texture2D>("Sprites/tentacule bléssé")};

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
            _spriteBatch.Draw(_HurtTexture[0], new Vector2((float)_positionX * 64, (float)_positionY * 64), null, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }



        //public string pathType;
        /*public void Move(string pathType) 
        {
            if (pathType == "vertical")
            {
                //if (direction = "up")
                // {//tant que pos y > pos finalup -> monte
                // direction = "down"}

                    //if (direction = "down")
                    // {//tant que pos y < pos finaldown -> descend
                    // direction = "up"}

            }
                else if (pathType == "random") 
            {
           //move(random)
            }
        }*/


    }
}
