using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SkeletonGame.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkeletonGame
{
    public static class Globals
    {
        public static float TotalSeconds { get; set; }
        public static SpriteBatch SpriteBatch { get; set; }
        public static GraphicsDevice graphicsDevice { get; set; }

        public static void Update(GameTime gameTime)
        {
            TotalSeconds = (float)gameTime.ElapsedGameTime.TotalSeconds;
        }
       

    }
}
