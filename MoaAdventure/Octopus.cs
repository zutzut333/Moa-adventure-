using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace MoaAdventure
{
    class Octopus : Creature
    {
        private int _Idletter;
        private int _positionX;
        private int _positionY;
        private List<Texture2D> _OctopusTexture;
        private SpriteBatch _spriteBatch;

        public Octopus(Game game, int IdLetter, int positionX, int positionY) : base(game, IdLetter, positionX, positionY)
        {
            _Idletter = IdLetter;
            _positionX = PositionX;
            _positionY = PositionY;
            LoadContent();
        }

        protected override void LoadContent()
        {
            _OctopusTexture = new List<Texture2D>() 
            { Game.Content.Load<Texture2D>("Sprites/tentacule sain")};


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
            _spriteBatch.Draw(_OctopusTexture[0], new Vector2(_positionX * 64, _positionY * 64), null, Color.White);
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
