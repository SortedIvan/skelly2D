using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SkeletonGame.Input;

namespace SkeletonGame.Entities.Player
{
    public class Player : GameObject
    {

        // Rectangle for player collision, to be removed with custom collision
        public Rectangle PlayerColision { get; set; }
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
