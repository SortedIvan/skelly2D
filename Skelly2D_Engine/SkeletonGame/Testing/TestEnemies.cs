using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SkeletonGame.EngineClasses;
using SkeletonGame.Entities.Player;
using SkeletonGame.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkeletonGame.Testing
{
    public class TestEnemies
    {
        private List<Enemy> enemies;
        private SpriteBatch spriteBatch;
        private Engine engine;
        Repository repository;

        private Texture2D collisionTexture;



        public TestEnemies(Repository repository, SpriteBatch spriteBatch, Engine engine, GraphicsDevice graphicsDevice)
        {
            enemies = new List<Enemy>();
            this.repository = repository;
            this.spriteBatch = spriteBatch;
            this.engine = engine;

                        /* Collision rectangles texture used to display the boxes around enemies 
            and the player*/
            collisionTexture = new Texture2D(graphicsDevice, 1, 1);
            collisionTexture.SetData<Color>(new Color[] { Color.White });

            this.enemies.Add(new Enemy(this.repository.GetTexture("skeleton_standing"), new Vector2(390, 90), 100));
            this.enemies.Add(new Enemy(this.repository.GetTexture("skeleton_standing"), new Vector2(150, 100), 100));
            this.enemies.Add(new Enemy(this.repository.GetTexture("skeleton_standing"), new Vector2(150, 250), 100));
            this.enemies.Add(new Enemy(this.repository.GetTexture("skeleton_standing"), new Vector2(250, 100), 100));
            this.enemies.Add(new Enemy(this.repository.GetTexture("skeleton_standing"), new Vector2(450, 500), 100));
        }

        private void SetEnemyCollisions(Enemy enemy)
        {
            Rectangle rectangle = new Rectangle((int)enemy.GetPosition().X, (int)enemy.GetPosition().Y, 100, 100);
            enemy.EnemyCol = rectangle;
        }

        public void Update()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].Update(engine.GetPlayer());
                SetEnemyCollisions(enemies[i]);
            }
            //SpaceOutEnemies();
        }


        /*
         Function to space out enemies from eachother, currently jittery as their collision is done with a rectangle.
         */
        private void SpaceOutEnemies()
        {
            for(int i = 0; i < enemies.Count - 1; i++)
            {
                if (enemies[i].EnemyCol.Intersects(enemies[i + 1].EnemyCol))
                {
                    //Vector2.Lerp(enemies[i].GetPosition(), Vector2.Add(new Vector2(30, 30), enemies[i + 1].GetPosition()), Globals.TotalSeconds);
                    enemies[i].SetPosition(new Vector2(enemies[i].GetPosition().X + 5, enemies[i].GetPosition().Y + 5));
                }
            }
        }
 
        
        public void Draw()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                this.spriteBatch.Draw(enemies[i].GetSprite(), enemies[i].GetPosition(), null, Color.White, 0, enemies[i].GetOrigin(), 1, SpriteEffects.None, 1);
                this.spriteBatch.Draw(collisionTexture,
                  enemies[i].GetPosition(),
                  enemies[i].EnemyCol,
                  Color.Red * 0.5f, //tint here, try Color.Red, Color.Green
                  0,
                  Vector2.Zero,
                  .5f, //scale
                  SpriteEffects.None,
                  0.00001f);
            }
            
        }

    }
}
