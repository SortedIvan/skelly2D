using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SkeletonGame.Exceptions;
using SkeletonGame.Factories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SkeletonGame.Repositories
{
    public class Repository
    {
        // Loaded textures holding all of the assets within the game
        private Dictionary<string, Texture2D> loadedTextures;
        private ContentManager content;        
        public Repository(ContentManager content)
        {
            this.content = content;
            this.loadedTextures = new Dictionary<string, Texture2D>();
        }

        public Texture2D LoadTexture(string textureName)
        {
            if (textureName.Equals(null))
            {
                throw new TextureException($"{textureName} is null. Please provide a correct texture name");
            }
            return content.Load<Texture2D>(textureName);
        }

        public void LoadAndSaveTexture(string textureName)
        {
            if (textureName.Equals(null))
            {
                throw new TextureException($"{textureName} is not valid. Please provide valid values.");
            }
            Debug.WriteLine("Texture has been saved");
            loadedTextures.Add(textureName, LoadTexture(textureName));
        }

        public Texture2D GetTexture(string textureName)
        {
            Texture2D texture;
            bool hasTexture = loadedTextures.TryGetValue(textureName, out texture);
            if (hasTexture)
            {
                return texture;
            }
            Debug.WriteLine($"{texture.ToString()} + {textureName}");
            throw new TextureException($"Texture with name: {textureName} has not been found");
        }


    }
}
