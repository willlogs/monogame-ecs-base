using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Main.Component.Physics.Colliders
{
    class RectCollider : Collider
    {
        protected Vector2 _center;
        protected float _width, _height;

        public RectCollider(Entity.Entity attachee, float width, float height, Vector2 center) : base(attachee) 
        {
            _width = width;
            _height = height;
            _center = center;
        }

        protected override Vector2 GetGlobalCenter()
        {
            return _center + attachee.transform.position;
        }

        public override float GetBottom()
        {
            return GetGlobalCenter().Y + _height / 2;
        }

        public override Vector2 GetCenter()
        {
            return GetGlobalCenter();
        }

        public override float GetLeft()
        {
            return GetGlobalCenter().X - _width / 2;
        }

        public override float GetRight()
        {
            return GetGlobalCenter().X + _width / 2;
        }

        public override float GetTop()
        {
            return GetGlobalCenter().Y - _height / 2;
        }

        public override void Update(GameTime gt)
        {

        }

        public override void Draw(SpriteBatch sb)
        {

        }

        public override void Collide(int dir, Vector2 pushVector)
        {
            throw new NotImplementedException();
        }
    }
}
