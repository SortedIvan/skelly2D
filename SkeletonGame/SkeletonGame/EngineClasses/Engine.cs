using Microsoft.Xna.Framework.Content;
using SkeletonGame.Assets;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkeletonGame.EngineClasses
{
    // Main class for holding all of the public instances of helper classes
    public class Engine
    {
        private Asset assetManager;
        public Engine(ContentManager content)
        {
            this.assetManager = new Asset(content);
        }

        public Asset AssetManager()
        {
            return this.assetManager;
        }

    }
}
