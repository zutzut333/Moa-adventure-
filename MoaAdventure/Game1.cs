using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using  System.Collections.Generic;
using System.Diagnostics;

namespace MoaAdventure
{
    public class Game1 : Game
    {
        public const int WINDOW_WIDTH = 14 * 64;
        public const int WINDOW_HEIGHT = 10 * 64;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;


        private List<string> direction;

        public int ActualLevel = 1;
        private Texture2D _mainTexture;
        private Map _actualMap;
        public bool isDoorPassed = true;

        private List<Texture2D> _backgroundsList;


        public Game1()
        {
         /*   direction.Add("up");
            direction.Add("down");
            direction.Add("left");
            direction.Add("right");
            direction.Add("random"); */
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
           _graphics.PreferredBackBufferWidth = WINDOW_WIDTH;
           _graphics.PreferredBackBufferHeight = WINDOW_HEIGHT;

        }

        protected override void Initialize()
        {


            base.Initialize();
        }

        protected override void LoadContent()
        {

            _backgroundsList = new List<Texture2D>();

            _backgroundsList.Add(Content.Load<Texture2D>("Sprites/background wood"));
            _backgroundsList.Add(Content.Load<Texture2D>("Sprites/background snow"));
            _backgroundsList.Add(Content.Load<Texture2D>("Sprites/background_champs"));
            _backgroundsList.Add(Content.Load<Texture2D>("Sprites/background_fortress"));

            _spriteBatch = new SpriteBatch(GraphicsDevice);


            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // TODO: Add your update logic here

           if( isDoorPassed == true ){ 
               switch (ActualLevel)
            {
                case 1:
                    _mainTexture = _backgroundsList[0]; 
                    _actualMap = new LevelLoader("../../../Data/CarteN1B1.txt").map;
                    Debug.WriteLine(_actualMap.TileIdAt(0,9));
                    Debug.WriteLine(_actualMap.HasWallAt(3,3));
                    isDoorPassed = false;
                    break;
                case 2:
                    _mainTexture = _backgroundsList[1];
                    _actualMap = new LevelLoader("../../../Data/CarteN2B2.txt").map;
                    isDoorPassed = false;
                        break;
                case 3:
                    _mainTexture = _backgroundsList[2];
                    _actualMap = new LevelLoader("../../../Data/CarteN3B3.txt").map;
                    isDoorPassed = false;
                        break;
                case 4:
                    _mainTexture = _backgroundsList[3];
                    _actualMap = new LevelLoader("../../../Data/CarteN4B4.txt").map;
                    isDoorPassed = false;
                        break;
            }}

            for (int line = 0; line < _actualMap.Height; line++)
            {
                for (int column = 0; column < _actualMap.Width; column++)
                {
                    Debug.WriteLine(_actualMap.TileIdAt(column, line));

                }
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {

            

            _spriteBatch.Begin();
            _spriteBatch.Draw(_mainTexture, new Vector2(0, 0), null, Color.White);
            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
