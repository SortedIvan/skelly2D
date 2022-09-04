using Microsoft.Xna.Framework.Graphics;
using SkeletonGame.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkeletonGame.Repository
{
    public class TextureRepository
    {
        private Dictionary<string, Texture2D> loadedTextures;
        public TextureRepository()
        {
            this.loadedTextures = new Dictionary<string, Texture2D>();
        }

        public void SaveLoadedTexture(string textureName, Texture2D texture)
        {
            if (textureName.Equals(null) || texture.Equals(null))
            {
                throw new TextureException($"{textureName} or {texture.ToString()} are not valid. Please provide valid values.");
            }
            this.loadedTextures.Add(textureName, texture);
        }

        public Texture2D GetTexture(string textureName)
        {
            Texture2D texture;
            bool hasTexture = this.loadedTextures.TryGetValue(textureName, out texture);
            if (hasTexture)
            {
                return texture;
            }
            throw new TextureException($"Texture with name: {textureName} has not been found");
        }

    }
}
