using Microsoft.Xna.Framework.Graphics;
using SkeletonGame.Assets;
using SkeletonGame.Exceptions;
using SkeletonGame.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkeletonGame.Repositories
{
    public class TextureRepository
    {
        private Dictionary<string, Texture2D> loadedTextures;
        private TextureFactory textureFactory;
        private Asset assetManager;
        public TextureRepository(TextureFactory textureFactory, Asset assetManager)
        {
            this.loadedTextures = new Dictionary<string, Texture2D>();
            this.textureFactory = textureFactory;
            this.assetManager = assetManager;
        }

        public void LoadAndSaveTexture(string textureName)
        {
            if (textureName.Equals(null))
            {
                throw new TextureException($"{textureName} is not valid. Please provide valid values.");
            }
            this.loadedTextures.Add(textureName, assetManager.LoadTexture(textureName));
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
