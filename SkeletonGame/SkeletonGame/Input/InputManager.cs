using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace SkeletonGame.Input
{
    public enum MouseInput
    {
        None,
        LeftBtn,
        RightBtn,
        MiddleBtn
    }

    public class InputManager
    {
        private KeyboardState keyboardState;
        public InputManager(KeyboardState keyboardState)
        {
            this.keyboardState = keyboardState;
        }

        public bool isBtnPressed(Keys key)
        {
            keyboardState = Keyboard.GetState();
            return this.keyboardState.IsKeyDown(key);
        }

        public bool isBtnHeld(Keys key)
        {
            keyboardState = Keyboard.GetState();
            Keys[] keys = this.keyboardState.GetPressedKeys();
            for(int i = 0; i < keys.Length; i++)
            {
                if(keys[i] == key)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
