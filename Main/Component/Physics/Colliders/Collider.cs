using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Main.Component.Physics.Colliders
{
    public abstract class Collider : Component, Main.Component.IVDebuggable
    {
        public static bool renderColliders = false;

        protected bool hasRB, lc, rc, dc, uc;
        protected RigidBodies.Rigidbody rb;

        public Collider(Entity.Entity attachee) : base(attachee)
        {
            rb = attachee.FindComponent<Main.Component.Physics.RigidBodies.Rigidbody>();           
            hasRB = rb != null;
            Main.Systems.ColiderSystem.CS.colliders.Add(this);
            Main.Rendering.Renderer.VDs.Add(this);
        }

        abstract protected Vector2 GetGlobalCenter();

        abstract public float GetLeft(); // min x
        abstract public float GetRight(); // max x
        abstract public float GetTop(); // min y
        abstract public float GetBottom(); // max y
        abstract public Vector2 GetCenter();
        abstract public void Draw(SpriteBatch sb);
        abstract public void Collide(int dir, Vector2 pushVector);
    }
}
