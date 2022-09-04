using SkeletonGame.Assets;
using SkeletonGame.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkeletonGame.Repositories
{
    public class Repository
    {
        private Asset assetManager;
        private TextureRepository textureRepository;
        public Repository(Asset assetManager)
        {
            this.assetManager = assetManager;
            this.textureRepository = new TextureRepository(this.assetManager);
        }

        public TextureRepository GetTextureRepository()
        {
            return this.textureRepository;
        }

        
    }
}
