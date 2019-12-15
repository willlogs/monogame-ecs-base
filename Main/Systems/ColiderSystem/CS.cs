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
        private static float pushOutSpeed = 5, fixedDeltaTime = 0.01f, timer = 0;

        public static List<Collider> colliders = new List<Collider>();

        private static bool DetectIntersection(float b00, float b01, float b10, float b11)
        {
            // TODO: add an error threshold
            bool result = false;

            if(b00 > b01)
            {
                if(b00 < b11)
                {
                    result = true;
                }
            }
            else
            {
                if(b10 < b11 && b10 > b01)
                {
                    result = true;
                }
            }

            return result;
        }

        public static void Update(GameTime gt)
        {
            timer += (float)gt.ElapsedGameTime.TotalSeconds;
            if (timer >= fixedDeltaTime)
            {
                timer = 0;
                foreach (Collider c1 in colliders)
                {
                    foreach (Collider c2 in colliders)
                    {
                        if(c1 != c2 && DoCollide(c1, c2))
                        {
                            // TODO: redundancy -> check if it has rb then do these calculations
                            c1.Collide(0, PushSpeedVector(c1, c2));
                            c1.Collide(0, PushSpeedVector(c2, c1));
                        }
                    }
                }
            }
        }

        public static bool DoCollide(Collider c1, Collider c2)
        {
            if(c1 is CircleCollider)
            {
                if (c2 is CircleCollider)
                {
                    return DoCollide((CircleCollider)c1, (CircleCollider)c2);
                }
            }

            throw new NotImplementedException();

            return false;
        }

        public static bool DoCollide(CircleCollider c1, CircleCollider c2)
        {
            float dist = MathUtils.GetDistance(c1.GetCenter(), c2.GetCenter());
            float radsum = c1.GetRadius() + c2.GetRadius();

            return dist <= radsum;
        }

        public static Vector2 PushSpeedVector(Collider main, Collider second)
        {
            if(main is CircleCollider)
            {
                if(second is CircleCollider)
                {
                    return PushSpeedVector((CircleCollider)main, (CircleCollider)second);
                }
            }

            throw new NotImplementedException();

            return Vector2.Zero;
        }

        public static Vector2 PushSpeedVector(CircleCollider main, CircleCollider second)
        {
            Vector2 pushV = second.GetCenter() - main.GetCenter();
            pushV.Normalize();
            return pushV * pushOutSpeed;
        }
    }
}
