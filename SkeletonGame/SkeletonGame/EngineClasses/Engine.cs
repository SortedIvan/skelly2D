using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SkeletonGame.Factories;
using SkeletonGame.Entities.Player;
using SkeletonGame.Input;
using SkeletonGame.Repositories;

namespace SkeletonGame.EngineClasses
{
    // Main class for holding all of the public instances of helper classes
    public class Engine
    {
        private Player player; // Player currently located in engine, will be moved to a sub-class
        private SpriteBatch spriteBatch;
        Repository repository;

        public Engine(Repository repository, SpriteBatch spriteBatch)
        {
           this.repository = repository;
           this.spriteBatch = spriteBatch;
           this.player = new Player(this.repository.GetTexture("skeleton_standing"), new Vector2(300, 300), 300);
        }

        public Player GetPlayer()
        {
            return this.player;
        }



        public void Update()
        {
            TestInputManager.Update();
            player.Update();
        }
        

        public void Draw()
        {
            this.spriteBatch.Draw(player.GetSprite(), player.GetPosition(), null, Color.White, 0, player.GetOrigin(), 1, SpriteEffects.None, 1);
        }

    }
}
