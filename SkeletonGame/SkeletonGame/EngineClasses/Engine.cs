using Microsoft.Xna.Framework.Content;
using SkeletonGame.Assets;
using SkeletonGame.Factories;
using SkeletonGame.Repositories;

namespace SkeletonGame.EngineClasses
{
    // Main class for holding all of the public instances of helper classes
    public class Engine
    {
        private Asset assetManager;
        private Repository repository;
        private TextureFactory textureFactory;
        private TextureLoader textureLoader;
        public Engine(ContentManager content)
        {
            //Asset manager is one of the most important manager classes
            this.assetManager = new Asset(content);
            this.textureFactory = new TextureFactory();
            this.repository = new Repository(assetManager);
            this.textureLoader = new TextureLoader(this.repository);
        }

        public Asset AssetManager()
        {
            return this.assetManager;
        }

        public TextureFactory TextureFactory()
        {
            return this.textureFactory;
        }

        // Main repository class, holding references to all of the repository classes.
        public Repository Repository()
        {
            return this.repository;
        }

        public TextureLoader TextureLoader()
        {
            return this.textureLoader;
        }
    }
}
