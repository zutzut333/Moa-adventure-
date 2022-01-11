using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using  System.Collections.Generic;

namespace MoaAdventure
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public int ActualLevel = 1;
        private Texture2D _mainTexture;
        private Map _actualMap;
        private List<Texture2D> _backgroundsList;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
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

            switch (ActualLevel)
            {
                case 1:
                    _mainTexture = _backgroundsList[0];
                    _actualMap = new LevelLoader("./CarteN1B1.txt").map;
                    break;
                case 2:
                    _mainTexture = _backgroundsList[1];
                    break;
                case 3:
                    _mainTexture = _backgroundsList[2];
                    break;
                case 4:
                    _mainTexture = _backgroundsList[3];
                    break;
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
