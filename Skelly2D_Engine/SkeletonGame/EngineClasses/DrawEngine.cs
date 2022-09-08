using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkeletonGame.EngineClasses
{
    public class DrawEngine
    {
        private SpriteBatch spriteBatch;
        private GraphicsDevice graphicsDevice;

        public DrawEngine(SpriteBatch spriteBatch, GraphicsDevice graphicsDevice)
        {
            this.spriteBatch = spriteBatch;
            this.graphicsDevice = graphicsDevice;
        }




    }
}
