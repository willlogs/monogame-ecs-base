using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Main.Entity;

namespace Main.Component
{
    public abstract class Component : IECSActor
    {
        public Entity.Entity attachee;

        public Component(Entity.Entity attachee)
        {
            this.attachee = attachee;
        }

        public abstract void Update(GameTime gt);
    }
}