using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SkeletonGame.Input;

namespace SkeletonGame.GameObject.Player
{
    public class Player : GameObject
    {
        public float PlayerSpeed { get; set; }
        public Player(Texture2D sprite, Vector2 pos, float playerSpeed)
            : base(sprite,pos)
        {
            this.PlayerSpeed = playerSpeed;
        }

        public void Update()
        {
            if (TestInputManager.Direction != Vector2.Zero)
            {
                var dir = Vector2.Normalize(TestInputManager.Direction);
                position += dir * PlayerSpeed * Globals.TotalSeconds;
            }
        }


    }
}
