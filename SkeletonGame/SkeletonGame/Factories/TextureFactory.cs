using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkeletonGame.Factories
{
    public class TextureFactory
    {
        public TextureFactory()
        {
        }

        public Texture2D CreateTexture(GraphicsDevice graphicsDevice, int width, int height)
        {
            return new Texture2D(graphicsDevice, width, height);
        }

        public Texture2D CreateTexture(GraphicsDevice graphicsDevice, int width, int height, bool mipmap, SurfaceFormat format)
        {
            return new Texture2D(graphicsDevice, width, height);
        }

        public Texture2D CreateTexture(GraphicsDevice graphicsDevice, int width, int height, bool mipmap, SurfaceFormat format, int arraySize)
        {
            return new Texture2D(graphicsDevice, width, height, mipmap, format, arraySize);
        }

    }
}
