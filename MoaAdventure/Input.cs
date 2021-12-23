using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MoaAdventure
{
    public class Input
    {
        public static bool ExitRequested
        {
            get { return GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape); }
        }

        public static bool PlayerDown
        {
            get { return Keyboard.GetState().IsKeyDown(Keys.Down); }
        }

        public static bool PlayerUp
        {
            get { return Keyboard.GetState().IsKeyDown(Keys.Up); }
        }

        public static bool PlayerLeft
        {
            get { return Keyboard.GetState().IsKeyDown(Keys.Left); }
        }

        public static bool PlayerRight
        {
            get { return Keyboard.GetState().IsKeyDown(Keys.Right); }
        }
    }
}