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
        Point playerOffset = new Point(-300, -300);
        Repository repository;

        private Texture2D collisionTexture;


        public Engine(Repository repository, SpriteBatch spriteBatch, GraphicsDevice graphicsDevice)
        {
           this.repository = repository;
           this.spriteBatch = spriteBatch;
           this.player = new Player(this.repository.GetTexture("skeleton_standing"), new Vector2(300, 300), 300);
           

                        /* Collision rectangles texture used to display the boxes around enemies 
            and the player*/
            collisionTexture = new Texture2D(graphicsDevice, 1, 1);
            collisionTexture.SetData<Color>(new Color[] { Color.White });

        }

        public Player GetPlayer()
        {
            return this.player;
        }

        private void UpdateCollisions()
        {
            this.player.PlayerColision = new Rectangle((int)player.GetPosition().X, (int)player.GetPosition().Y, 50, 50);
        }


        public void Update()
        {
            TestInputManager.Update();
            player.Update();
            UpdateCollisions();
        }


//        So if your Hitbox is 32x32 then it’s going to be:
//X = GameObject.X
//Y = GameObject.Y
//Width = 32 Height= 32

        public void Draw()
        {
            this.spriteBatch.Draw(player.GetSprite(), player.GetPosition(), null, Color.White, 0, player.GetOrigin(), 1, SpriteEffects.None, 1);

            this.spriteBatch.Draw(collisionTexture,
              player.GetPosition(),
              null,
              //player.PlayerColision,
              Color.Yellow * 0.5f, //tint here, try Color.Red, Color.Green
              0,
              player.GetOrigin(),
              1f, //scale
              SpriteEffects.None,
              0.00001f);
           }
    }

}

