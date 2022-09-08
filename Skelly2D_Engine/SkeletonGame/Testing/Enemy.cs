using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SkeletonGame.Entities;
using SkeletonGame.Entities.Player;
using SkeletonGame.Input;

namespace SkeletonGame.Testing
{
    public class Enemy : GameObject 
    {
        public float EnemySpeed { get; set; }
        public Rectangle EnemyCol { get; set; }

        public Enemy(Texture2D sprite, Vector2 pos, float enemySpeed)
            : base(sprite, pos)
        {
            this.EnemySpeed = enemySpeed;
        }

        public void Update(Player player)
        {
            if (player.PlayerColision.Intersects(EnemyCol))
            {
                position = Vector2.Lerp(position, player.GetPosition(), Globals.TotalSeconds);
            }
        }



        //Color[] data = new Color[rectangle.Width * rectangle.Height];
        //Texture2D rectTexture = new Texture2D(GraphicsDevice, rectangle.Width, rectangle.Height);

        // for (int i = 0; i<data.Length; ++i) 
        //      data[i] = Color.White;

        // rectTexture.SetData(data);
        // var position = new Vector2(rectangle.Left, rectangle.Top);

        //spriteBatch.Draw(rectTexture, position, Color.White);

    }
}
