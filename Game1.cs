using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CHESS_BOARD
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D rectangle;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 640;
            _graphics.PreferredBackBufferHeight = 640;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            rectangle = Content.Load<Texture2D>("rectangle");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            // TODO: Add your drawing code here
            for (int i = 0; i < 8; i += 2)
            {
                for (int j = 0; j < 8; j += 2)
                {
                    _spriteBatch.Draw(rectangle, new Rectangle(80 * i, 80 * j, 80, 80), Color.White);

                }

            }
            for (int i = 1; i < 8; i += 2)
            {
                for (int j = 0; j < 8; j += 2)
                {
                    _spriteBatch.Draw(rectangle, new Rectangle(80 * i, 80 * j, 80, 80), Color.Black);

                }

            }
            for (int i = 0; i < 8; i += 2)
            {
                for (int j = 1; j < 8; j += 2)
                {
                    _spriteBatch.Draw(rectangle, new Rectangle(80 * i, 80 * j, 80, 80), Color.Black);

                }

            }
            for (int i = 1; i < 8; i += 2)
            {
                for (int j = 1; j < 8; j += 2)
                {
                    _spriteBatch.Draw(rectangle, new Rectangle(80 * i, 80 * j, 80, 80), Color.White);

                }

            }
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}