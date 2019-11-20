using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Main.Component.Transform
{
    public class Transform2D : Component
    {
        public Vector2 position;
        public float scale;
        public float rotationZ;

        public Transform2D(Vector2 pos, float scale, Entity.Entity attachee, float rot = 0)
            :base(attachee)
        {
            this.position = pos;
            this.scale = scale;
            this.rotationZ = rot;
        }

        public void Translate(Vector2 distance)
        {
            position += distance;
        }

        public override void Update(GameTime gt)
        {

        }
    }
}
