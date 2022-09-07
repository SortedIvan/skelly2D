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


        public TestEnemies(Repository repository, SpriteBatch spriteBatch, Engine engine)
        {
            enemies = new List<Enemy>();
            this.repository = repository;
            this.spriteBatch = spriteBatch;
            this.engine = engine;

            this.enemies.Add(new Enemy(this.repository.GetTexture("skeleton_standing"), new Vector2(100, 100), 100));
            this.enemies.Add(new Enemy(this.repository.GetTexture("skeleton_standing"), new Vector2(150, 100), 100));
            this.enemies.Add(new Enemy(this.repository.GetTexture("skeleton_standing"), new Vector2(200, 100), 100));
            this.enemies.Add(new Enemy(this.repository.GetTexture("skeleton_standing"), new Vector2(250, 100), 100));
            this.enemies.Add(new Enemy(this.repository.GetTexture("skeleton_standing"), new Vector2(300, 100), 100));
        }

        public void Update()
        {
            for(int i = 0; i < enemies.Count; i++)
            {
                enemies[i].Update(engine.GetPlayer());
            }
        }

       

        public void Draw()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                this.spriteBatch.Draw(enemies[i].GetSprite(), enemies[i].GetPosition(), null, Color.White, 0, enemies[i].GetOrigin(), 1, SpriteEffects.None, 1);
            }
            
        }

    }
}
