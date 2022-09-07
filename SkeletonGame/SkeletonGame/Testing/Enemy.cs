using System;
using System.Collections.Generic;
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
        public Enemy(Texture2D sprite, Vector2 pos, float enemySpeed)
            : base(sprite, pos)
        {
            this.EnemySpeed = enemySpeed;
        }

        public void Update(Player player)
        {
            position = Vector2.Lerp(position, player.GetPosition(), Globals.TotalSeconds);
        }

    }
}
