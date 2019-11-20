using System;
using System.Collections.Generic;
using System.Text;

using Main.Component.Physics.Colliders;
using Main.Utils;
using Microsoft.Xna.Framework;

namespace Main.Systems.ColiderSystem
{
    public static class CS
    {
        private static float pushOutSpeed = 20;

        public static bool DoCollide(CircleCollider c1, CircleCollider c2)
        {
            float dist = MathUtils.GetDistance(c1.GetCenter(), c2.GetCenter());
            float radsum = c1.GetRadius() + c2.GetRadius();

            return dist <= radsum;
        }
        public static Vector2 PushSpeedVector(CircleCollider main, CircleCollider second)
        {
            Vector2 pushV = second.GetCenter() - main.GetCenter();
            pushV.Normalize();
            return pushV * 20;
        }
    }
}
