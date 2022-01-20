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

        private List<Texture2D> _backgroundsPathList;
        private List<Texture2D> _heroPathList;
        private List<Texture2D> _wallPathList;
        private List<Texture2D> _spiderPathList;
        private List<Texture2D> _knightPathList;
        private List<Texture2D> _itemPathList;
        private List<Texture2D> _trapPathList;
        private List<Texture2D> _finalBossPathList;
        private Texture2D _buttonPath;
        private Texture2D _doorPath;


        public Game1()
        {
       
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
           _graphics.PreferredBackBufferWidth = WINDOW_WIDTH;
           _graphics.PreferredBackBufferHeight = WINDOW_HEIGHT;

        }

        protected override void Initialize()
        {
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


            _heroPathList = new List<Texture2D>() 
            {   Content.Load < Texture2D > ("Sprites/Perso haut"), 
                Content.Load<Texture2D>("Sprites/Perso face"), 
                Content.Load<Texture2D>("Sprites/Perso gauche"), 
                Content.Load<Texture2D>("Sprites/Perso droite") };

            _wallPathList = new List<Texture2D>() { Content.Load < Texture2D > ("Sprites/Brique"), Content.Load < Texture2D >( "Sprites/Glace") };

            _spiderPathList = new List<Texture2D>() 
            { Content.Load<Texture2D>("Sprites/Spider up"),
                Content.Load<Texture2D>("Sprites/Spider low"),
                Content.Load<Texture2D>("Sprites/Spider left"),
                Content.Load<Texture2D>("Sprites/Spider right") };

            _knightPathList = new List<Texture2D>() { Content.Load<Texture2D>("Sprites/Chevalier haut"), Content.Load<Texture2D>("Sprites/Chevalier bas") };

            _itemPathList = new List<Texture2D>() 
            { Content.Load<Texture2D>("Sprites/Carte"),
                Content.Load<Texture2D>("Sprites/épée magique"),
                Content.Load<Texture2D>("Sprites/Pierre Magique") };

            _buttonPath = Content.Load<Texture2D>("Sprites/Bouton");

             _trapPathList = new List<Texture2D>() { Content.Load<Texture2D>("Sprites/Mine"), Content.Load<Texture2D>("Sprites/trou de glace") };

            _finalBossPathList = new List<Texture2D>() { Content.Load<Texture2D>("Sprites/tentacule sain"), Content.Load<Texture2D>("Sprites/tentacule bléssé") };

            _doorPath = Content.Load<Texture2D>("Sprites/porte Magique");

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
                        isDoorPassed = false;
                        break;
                    case 2:
                        _mainTexture = _backgroundsPathList[1];
                        _actualMap = new LevelLoader("../../../Data/CarteN2B2.txt").map;
                        isDoorPassed = false;
                            break;
                    case 3:
                        _mainTexture = _backgroundsPathList[2];
                        _actualMap = new LevelLoader("../../../Data/CarteN3B3.txt").map;
                        isDoorPassed = false;
                            break;
                    case 4:
                        _mainTexture = _backgroundsPathList[3];
                        _actualMap = new LevelLoader("../../../Data/CarteN4B4.txt").map;
                        isDoorPassed = false;
                            break;
                }
                for (int line = 0; line < _actualMap.Height; line++)
                {
                    for (int column = 0; column < _actualMap.Width; column++)
                    { 
                        new CreateEntity (_actualMap.TileIdAt(column, line),column,line);
                    }
                }
            }

          

           

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {

            

            _spriteBatch.Begin();
            _spriteBatch.Draw(_mainTexture, new Vector2(0, 0), null, Color.White);
            _spriteBatch.Draw(_spiderPathList[1], new Vector2(0, 0), null, Color.White);
            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
