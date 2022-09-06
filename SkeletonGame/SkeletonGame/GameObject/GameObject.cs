using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SkeletonGame.GameObject
{
    public class GameObject
    {
        protected Texture2D sprite;
        protected Vector2 position;
        protected Vector2 origin;

        public GameObject(Texture2D sprite, Vector2 pos)
        {
            this.sprite = sprite;
            this.position = pos;
            this.origin = new Vector2(sprite.Width / 2, sprite.Height / 2);
        }


        public Texture2D GetSprite()
        {
            return this.sprite;
        }

        public Vector2 GetPosition()
        {
            return this.position;
        }

        public Vector2 GetOrigin()
        {
            return this.origin;
        }


    }
}
