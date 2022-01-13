using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using  System.Collections.Generic;

namespace MoaAdventure
{
    public class Game1 : Game
    {
        public const int WINDOW_WIDTH = 14 * 64;
        public const int WINDOW_HEIGHT = 10 * 64;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public int ActualLevel = 1;
        private Texture2D mainTexture;


        private List<string> direction;
        private List<Texture2D> _backgroundsList;


        public Game1()
        {
            direction.Add("up");
            direction.Add("down");
            direction.Add("left");
            direction.Add("right");
            direction.Add("random");
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

            switch (ActualLevel)
            {
                case 1:
                    mainTexture = _backgroundsList[0];
                    break;
                case 2:
                    mainTexture = _backgroundsList[1];
                    break;
                case 3:
                    mainTexture = _backgroundsList[2];
                    break;
                case 4:
                    mainTexture = _backgroundsList[3];
                    break;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {

            

            _spriteBatch.Begin();
            _spriteBatch.Draw(mainTexture, new Vector2(0, 0), null, Color.White);
            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
