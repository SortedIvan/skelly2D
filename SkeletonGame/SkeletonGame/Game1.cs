using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SkeletonGame.EngineClasses;
using SkeletonGame.Entities.Player;
using SkeletonGame.Repositories;
using SkeletonGame.Testing;

namespace SkeletonGame
{
    public class Game1 : Game
    {
        //_graphics and _spriteBatch for drawing textures;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        /* 
         Working on dissasembling the Engine class and repository
          --- Completed, Repository is loaded before Engine 
               (to load all of the content and avoid exceptions)
          ->
         */
        private Repository repository;
        private Engine engine;


        /* Testing enemies behaviour with Vector2.Lerp to follow the player
         */
        private TestEnemies testEnemies;

        public Game1()
        {
            Content.RootDirectory = "Content";
            _graphics = new GraphicsDeviceManager(this);
            IsMouseVisible = true;
            this.repository = new Repository(Content);
        }

        protected override void Initialize()
        {
            base.Initialize(); // Initialize invokes -> LoadContent();
            this.engine = new Engine(this.repository, this._spriteBatch); // Main class controlling all of the subclasses
            this.testEnemies = new TestEnemies(this.repository, this._spriteBatch, this.engine);
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
            Globals.Update(gameTime); // In order to keep other components in sync
            engine.Update(); // Updating all of the logic kept within the player's class

            testEnemies.Update(); // Enemies behaviour, possible TO_BE_REMOVED

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();
            engine.Draw();

            testEnemies.Draw(); // Drawing out the enemies, to be removed.
            
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
