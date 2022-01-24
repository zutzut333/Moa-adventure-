using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using static MoaAdventure.Game1;

namespace MoaAdventure
{
    class Hero : Creature
    {
        private int _Idletter;
        private double _positionX;
        private double _positionY;
        private int _textureSense;
        private List<Texture2D> _HeroTexture;
        private SpriteBatch _spriteBatch;
        private static int _lifeNumber;
        

       public Hero(Game game, int IdLetter, double positionX, double positionY,int textureSense) : base(game, IdLetter, positionX, positionY, textureSense)
        {
            _Idletter = IdLetter;
            _positionX = PositionX;
            _positionY = PositionY;
            LoadContent();
            _lifeNumber = 3;
            _textureSense = textureSense;
            
           
        }
        public static int lifenumber 
        {
            get { return _lifeNumber; }
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

        public static void Die(int cause,Entity   deadCreature) 
        { 
            _lifeNumber--;
            if (_lifeNumber == 0) 
            {
                //GameOver();
            }
            else 
            {
                //LifeDecreased(cause);
                Game.Components.RemoveAt(Game.Components.IndexOf(deadCreature));
                Game1.isDoorPassed = true; 
            }
        }
        public override void Update(GameTime gameTime)
        {
            


            
            if (Input.PlayerUp)
            {
                _positionY = this.Move("up", _positionX, _positionY, gameTime).Item2;
                _textureSense = 0;
            }
                
            
            if (Input.PlayerDown) 
            { 
                _positionY = this.Move("down", _positionX, _positionY, gameTime).Item2;
                _textureSense = 1;
            }
                
            

            if (Input.PlayerLeft)
            {
                _positionX = this.Move("left", _positionX, _positionY, gameTime).Item1;
                _textureSense = 2;
            }

            if (Input.PlayerRight)
            {
                _positionX = this.Move("right", _positionX, _positionY, gameTime).Item1;
                _textureSense = 3;
            }


            //gérer les coliosion avec les bords de la fenêtre
           
                

            Draw(gameTime);
            base.Update(gameTime);

        }

        public override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();
            _spriteBatch.Draw(_HeroTexture[_textureSense], new Vector2((float)_positionX * 64, (float)_positionY * 64), null, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }

    }
}
