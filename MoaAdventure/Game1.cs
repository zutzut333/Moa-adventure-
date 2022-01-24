using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using  System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace MoaAdventure
{
    public class Game1 : Game
    {
        public const int WINDOW_WIDTH = 14 * 64;
        public const int WINDOW_HEIGHT = 10 * 64;
        public static GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;


        private List<string> direction;

<<<<<<< Updated upstream
<<<<<<< Updated upstream
        public static int ActualLevel =3 ;
=======
        public static int _lifeNumber;
        public static int ActualLevel =1 ;
>>>>>>> Stashed changes
=======
        public static int _lifeNumber;
        public static int ActualLevel =1 ;
>>>>>>> Stashed changes
        private Texture2D _mainTexture;
        public Map _actualMap;
        public static bool isDoorPassed = true;

        private List<Texture2D> _backgroundsPathList;
        private List<Entity> _createdEntity;

        public Game1()
        {
       
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
           _graphics.PreferredBackBufferWidth = WINDOW_WIDTH;
           _graphics.PreferredBackBufferHeight = WINDOW_HEIGHT;
           _createdEntity = new List<Entity>();

        }


        protected override void Initialize()
        {
            _lifeNumber = 3;
            direction = new List<string>(){ "up","down","left","right","random"};
            
            base.Initialize();
        }

        protected override void LoadContent()
        {

                _backgroundsPathList = new List<Texture2D>() 
            { Content.Load<Texture2D>("Sprites/background wood"),
                Content.Load < Texture2D > ("Sprites/background snow"),
                Content.Load < Texture2D > ("Sprites/background_champs"),
                Content.Load < Texture2D > ("Sprites/background_fortress") };

            _spriteBatch = new SpriteBatch(GraphicsDevice);
           
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

           if( isDoorPassed == true ){ 
               switch (ActualLevel)
                {
                    case 1:
                        _mainTexture = _backgroundsPathList[0]; 
                        _actualMap = new LevelLoader("../../../Data/CarteN1B1.txt").map;
                        Debug.WriteLine(_actualMap.TileIdAt(12,0));
                        break;
                    case 2:
                        _mainTexture = _backgroundsPathList[1];
                        _actualMap = new LevelLoader("../../../Data/CarteN2B2.txt").map;
                        break;
                    case 3:
                        _mainTexture = _backgroundsPathList[2];
                        _actualMap = new LevelLoader("../../../Data/CarteN3B3.txt").map;
                        break;
                    case 4:
                        _mainTexture = _backgroundsPathList[3];
                        _actualMap = new LevelLoader("../../../Data/CarteN4B4.txt").map;
                        break;
                }

               for (int line = 0; line < _actualMap.Height; line++)
               {
                   for (int column = 0; column < _actualMap.Width; column++)
                   {
                       new CreateEntity(this, _actualMap.TileIdAt(column, line), column, line, gameTime, ActualLevel);

                   }
               }

                isDoorPassed = false;

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
