﻿using System;
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
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;


        private List<string> direction;

        public int ActualLevel = 4;
        private Texture2D _mainTexture;
        private Map _actualMap;
        public bool isDoorPassed = true;

        private List<Texture2D> _backgroundsPathList;
        private List<Texture2D> _heroPathList;
        private List<Texture2D> _wallPathList;
        private List<Texture2D> _itemPathList;
        private List<Texture2D> _trapPathList;
        private List<Texture2D> _finalBossPathList;
        private Texture2D _buttonPath;
        private Texture2D _doorPath;
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
            direction = new List<string>(){ "up","down","left","right","random"};
            
            base.Initialize();
        }

        protected override void LoadContent()
        {


            _wallPathList = new List<Texture2D>()
            {
                Content.Load<Texture2D>("Sprites/Bois"),
                Content.Load < Texture2D > ("Sprites/Glace"),
                Content.Load < Texture2D > ("Sprites/Brique"),
                Content.Load < Texture2D > ("Sprites/Beton")
            };

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


            _itemPathList = new List<Texture2D>() 
            { Content.Load<Texture2D>("Sprites/Carte"),
                Content.Load<Texture2D>("Sprites/épée magique"),
                Content.Load<Texture2D>("Sprites/Pierre Magique") };

            _buttonPath = Content.Load<Texture2D>("Sprites/Bouton");

             _trapPathList = new List<Texture2D>() { Content.Load<Texture2D>("Sprites/Mine"), Content.Load<Texture2D>("Sprites/trou de glace") };

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
                       new CreateEntity(this, _actualMap.TileIdAt(column, line), column, line, gameTime);

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
