using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SkeletonGame.EngineClasses;
using SkeletonGame.GameObject.Player;
using SkeletonGame.Repositories;

namespace SkeletonGame
{
    public class Game1 : Game
    {
        //_graphics and _spriteBatch for drawing textures;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        /* 
         Working on dissasembling the Engine class and repository
          ->
         */
        private Repository repository;
        private Engine engine;


        public Game1()
        {
            Content.RootDirectory = "Content";
            _graphics = new GraphicsDeviceManager(this);
            IsMouseVisible = true;
            this.repository = new Repository(Content);
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.engine = new Engine(this.repository, this._spriteBatch); // Main class controlling all of the subclasses
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            repository.LoadAndSaveTexture("skeleton_standing");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // TODO: Add your update logic here
            engine.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();
            engine.Draw();

            //player.Draw();
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
