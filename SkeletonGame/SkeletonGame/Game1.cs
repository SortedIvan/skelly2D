using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SkeletonGame.Input;
using System.Diagnostics;
using SkeletonGame.EngineClasses;
namespace SkeletonGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private KeyboardState keyboardState;
        private InputManager inputManager;
        private Engine engine;

        Texture2D texture2D;

        public Game1()
        {
            this.keyboardState = new KeyboardState();
            _graphics = new GraphicsDeviceManager(this);
            this.inputManager = new InputManager(keyboardState);
            Content.RootDirectory = "Content";
            this.engine = new Engine(Content);
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            // Testing whether InputManager works
            if (this.inputManager.isBtnPressed(Keys.Space))
            {
                Debug.WriteLine($"Button {Keys.Space.ToString()} is currently being held");
            }
 
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(this.engine.AssetManager().LoadTexture("skeleton_standing"), 
                new Rectangle(0, 0, _graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight), Color.White);
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
