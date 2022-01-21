using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using testMG.core;


namespace testMG
{
    public class Game1 : Game
    {
        public const int WINDOW_WIDTH = 14*64;
        public const int WINDOW_HEIGHT = 10*64;
        World world;
        Texture2D ball1Texture;
        Texture2D ball2Texture;
        Vector2 ball1Position;
        Vector2 ball2Position;
       
        float ballSpeed;
        private SpriteFont police ;
        private string message  = "Game Over";

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

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
         
            world = new World();
            ball1Position = new Vector2(64,64);
            ball2Position = new Vector2(64,129);
            ballSpeed = 500f;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            world.Texture = Content.Load<Texture2D>("terre");
            world.Position = new Vector2(WINDOW_WIDTH,32);
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            ball1Texture = Content.Load<Texture2D>("ball");
            ball2Texture = Content.Load<Texture2D>("Perso test");
            
            police = Content.Load<SpriteFont>("File");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            if (seTouche(ball1Position, ball2Position) == false)
            {
                var kstate = Keyboard.GetState();

          

                if (kstate.IsKeyDown(Keys.Down))
                    ball1Position.Y += ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

                if (kstate.IsKeyDown(Keys.Left))
                    ball1Position.X -= ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

                if (kstate.IsKeyDown(Keys.Right))
                    ball1Position.X += ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

                if (kstate.IsKeyDown(Keys.Up))
                    ball1Position.Y -= ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

                if (ball1Position.X > _graphics.PreferredBackBufferWidth - ball1Texture.Width / 2)
                    ball1Position.X = _graphics.PreferredBackBufferWidth - ball1Texture.Width / 2;
                else if (ball1Position.X < ball1Texture.Width / 2)
                    ball1Position.X = ball1Texture.Width / 2;

                if (ball1Position.Y > _graphics.PreferredBackBufferHeight - ball1Texture.Height / 2)
                    ball1Position.Y = _graphics.PreferredBackBufferHeight - ball1Texture.Height / 2;
                else if (ball1Position.Y < ball1Texture.Height / 2)
                    ball1Position.Y = ball1Texture.Height / 2;


                if (kstate.IsKeyDown(Keys.S))
                    ball2Position.Y += ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

                if (kstate.IsKeyDown(Keys.A))
                    ball2Position.X -= ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

                if (kstate.IsKeyDown(Keys.D))
                    ball2Position.X += ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

                if (kstate.IsKeyDown(Keys.W))
                    ball2Position.Y -= ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

                if (ball2Position.X > _graphics.PreferredBackBufferWidth - ball2Texture.Width / 2)
                    ball2Position.X = _graphics.PreferredBackBufferWidth - ball2Texture.Width / 2;
                else if (ball2Position.X < ball2Texture.Width / 2)
                    ball2Position.X = ball2Texture.Width / 2;

                if (ball2Position.Y > _graphics.PreferredBackBufferHeight - ball2Texture.Height / 2)
                    ball2Position.Y = _graphics.PreferredBackBufferHeight - ball2Texture.Height / 2;
                else if (ball2Position.Y < ball2Texture.Height / 2)
                    ball2Position.Y = ball2Texture.Height / 2;
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            

            _spriteBatch.Begin();

            
            for (int i = 1; i < 15; i++)
            {
                _spriteBatch.Draw(
                  world.Texture,
                  world.Position,
                  null,
                  Color.White,
                  0f,
                  new Vector2(2*i*(world.Texture.Width / 2), world.Texture.Height / 2),
                  new Vector2(0.25f),
                    SpriteEffects.None,
                    0f

                  );
                    
            }
          
            
            _spriteBatch.Draw(
                 ball1Texture,
                 ball1Position,
                 null,
                 Color.White,
                 0f,
                 new Vector2(ball1Texture.Width / 2, ball1Texture.Height / 2),
                 Vector2.One,
                 SpriteEffects.None,
                 0f
             );

            _spriteBatch.Draw(
                 ball2Texture,
                 ball2Position,
                 null,
                 Color.White,
                 0f,
                 new Vector2(ball2Texture.Width / 2, ball2Texture.Height / 2),
                 Vector2.One,
                 SpriteEffects.None,
                 0f
             );

            _spriteBatch.DrawString(police,message, new Vector2(100, 100), Color.Black);
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
        protected bool seTouche(Vector2 premier,Vector2 second) {
            double calculated;
            calculated = Math.Sqrt(Math.Pow(MathHelper.Distance(premier.X, second.X),2) + Math.Pow(MathHelper.Distance(premier.Y, second.Y),2));
            if (calculated < ball1Texture.Width)
            {
                return true;
            }
            else { return false; }
        }
    }
}
