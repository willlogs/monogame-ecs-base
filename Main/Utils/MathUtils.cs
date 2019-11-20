using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Main.Utils
{
    public static class MathUtils
    {
        public static float GetDistance(Vector2 v1, Vector2 v2)
        {
            float x, y;

            x = MathHelper.Distance(v1.X, v2.X);
            y = MathHelper.Distance(v1.Y, v2.Y);

            x *= x;
            y *= y;

            return (float)System.Math.Sqrt(x + y);
        }
    }
}
