using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Main.Rendering
{
    public static class Renderer
    {
        public static List<Component.Rendering.Sprite> sprites = new List<Component.Rendering.Sprite>();
        public static List<Main.Component.IVDebuggable> VDs = new List<Main.Component.IVDebuggable>();

        public static void Draw(SpriteBatch sb)
        {
            foreach (Component.Rendering.Sprite sprite in sprites)
            {
                sprite.Draw(sb);
            }

            foreach (Main.Component.IVDebuggable VD in VDs)
            {
                VD.Draw(sb);
            }
        }
    }
}
