using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MoaAdventure
{
    public class Game1 : Game
    {
        public const int WINDOW_WIDTH = 14 * 64;
        public const int WINDOW_HEIGHT = 10 * 64;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        //World world;
        //Hero hero;
        Vector2 heroPosition;
        Texture2D heroTextureFace;
        Texture2D heroTextureGauche;
        Texture2D heroTextureDroite;
        Texture2D heroTextureBack;
        Texture2D heroTexture;

        float heroSpeed;

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
            // TODO: Add your initialization logic here
           // world = new World();
            heroPosition = new Vector2(64, 64);
            heroSpeed=500f;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            heroTexture = Content.Load<Texture2D>("obj/Windows/Content/Perso face");
            heroTextureGauche = Content.Load<Texture2D>("obj/Windows/Content/Perso gauche");
            heroTextureBack = Content.Load<Texture2D>("obj/Windows/Content/Perso haut");
            heroTextureDroite = Content.Load<Texture2D>("obj/Windows/Content/Perso droite");
            heroTextureFace = Content.Load<Texture2D>("obj/Windows/Content/Perso face");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            var kstate = Keyboard.GetState();



            if (kstate.IsKeyDown(Keys.Down))
            {
                heroPosition.Y += heroSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                heroTexture = heroTextureFace;
            }
                

            if (kstate.IsKeyDown(Keys.Left))
            {
                heroPosition.X -= heroSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                heroTexture = heroTextureGauche;
            }
               
            if (kstate.IsKeyDown(Keys.Right)) 
            {
                heroPosition.X += heroSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                heroTexture = heroTextureDroite;
            }
                
            if (kstate.IsKeyDown(Keys.Up)) 
            {
                heroPosition.Y -= heroSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                heroTexture = heroTextureBack;
            }
                
            if (heroPosition.X > _graphics.PreferredBackBufferWidth - heroTexture.Width / 2)
                heroPosition.X = _graphics.PreferredBackBufferWidth - heroTexture.Width / 2;
            else if (heroPosition.X < heroTexture.Width / 2)
                heroPosition.X = heroTexture.Width / 2;

            if (heroPosition.Y > _graphics.PreferredBackBufferHeight - heroTexture.Height / 2)
                heroPosition.Y = _graphics.PreferredBackBufferHeight - heroTexture.Height / 2;
            else if (heroPosition.Y < heroTexture.Height / 2)
                heroPosition.Y = heroTexture.Height / 2;
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            // TODO: Add your drawing code here
            _spriteBatch.Draw(
                 heroTexture,
                 heroPosition,
                 null,
                 Color.White,
                 0f,
                 new Vector2(heroTexture.Width / 2, heroTexture.Height / 2),
                 Vector2.One,
                 SpriteEffects.None,
                 0f
             );
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
