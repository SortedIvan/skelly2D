using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SkeletonGame.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkeletonGame.Assets
{
    public class Asset
    {
        private ContentManager content;
        public Asset(ContentManager content)
        {
            this.content = content;   
        }
        
        public Texture2D LoadTexture(string textureName)
        {
            if (textureName.Equals(null))
            {
                throw new TextureException($"{textureName} is null. Please provide a correct texture name");
            }
            return this.content.Load<Texture2D>(textureName);
        }



    }
}
