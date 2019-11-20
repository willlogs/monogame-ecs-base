using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Main.Component.Physics.Colliders
{
    public abstract class Collider : Component
    {
        private bool hasRB;
        private RigidBodies.Rigidbody rb;

        public Collider(Entity.Entity attachee) : base(attachee) 
        {
            rb = attachee.FindComponent<Main.Component.Physics.RigidBodies.Rigidbody>();
            if(rb != null)
            {
                hasRB = true;
            }
        }

        abstract public float GetLeft(); // min x
        abstract public float GetRight(); // max x
        abstract public float GetTop(); // min y
        abstract public float GetBottom(); // max y
        abstract public Vector2 GetCenter();
    }
}
