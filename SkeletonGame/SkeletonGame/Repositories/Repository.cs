using SkeletonGame.Assets;
using SkeletonGame.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkeletonGame.Repositories
{
    public class Repository
    {
        private TextureFactory textureFactory;
        private Asset assetManager;
        private TextureRepository textureRepository;
        public Repository(TextureFactory textureFactory, Asset assetManager)
        {
            this.textureFactory = textureFactory;
            this.assetManager = assetManager;
            this.textureRepository = new TextureRepository(this.textureFactory,this.assetManager);
        }

        public TextureRepository GetTextureRepository()
        {
            return this.textureRepository;
        }

        
    }
}
