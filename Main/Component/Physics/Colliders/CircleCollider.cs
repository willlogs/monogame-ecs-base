using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Main.Component.Physics.Colliders
{
    public class CircleCollider : Collider
    {
        // Private Vars
        private Vector2 _center;
        private float _radius;

        // Constructor
        public CircleCollider(Entity.Entity attachee) : base(attachee) { }

        // Public Functions
        public override Vector2 GetCenter()
        {
            return _center;
        }

        public override float GetBottom()
        {
            return _center.Y + _radius;
        }

        public override float GetLeft()
        {
            return _center.X - _radius;
        }

        public override float GetRight()
        {
            return _center.X + _radius;
        }

        public override float GetTop()
        {
            return _center.Y - _radius;
        }

        public float GetRadius()
        {
            return _radius;
        }

        public override void Update(GameTime gt)
        {
            throw new NotImplementedException();
        }
    }
}
