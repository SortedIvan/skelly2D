using System;
using System.Collections.Generic;
using System.Text;

namespace SkeletonGame.Repositories
{
    // Class for loading all textures
    public class TextureLoader
    {
        private Repository repository;
        public TextureLoader(Repository repository)
        {
            this.repository = repository;
        }

        // Function that is called once -> loads all of the textures here
        public void LoadAllTextures()
        {
            TextureRepository textureRepository = this.repository.GetTextureRepository();
            textureRepository.LoadAndSaveTexture("skeleton_standing");
        }

    }
}
