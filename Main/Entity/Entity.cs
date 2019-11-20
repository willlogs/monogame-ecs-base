using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Main.Entity
{
    public class Entity : IECSActor
    {
        public Scene.Scene attachee;
        public List<Component.Component> components;
        public Main.Component.Transform.Transform2D transform;
        public string name;
        public int tag; // tag = -1 means the tag has not been assigned

        public Entity(Vector2 position, float scale, string name = "Game Object", int tag = -1)
        {
            this.name = name;
            this.tag = tag;
            this.transform = new Main.Component.Transform.Transform2D(position, scale, this);
            components = new List<Component.Component>();
        }

        public void Update(GameTime gt)
        {
            CallComponentsUpdates(gt);
        }

        public void AddComponent(Main.Component.Component comp)
        {
            if (!(comp is Main.Component.Transform.Transform2D))
            {
                components.Add(comp);
            }
        }

        public T FindComponent<T>() where T : Main.Component.Component
        {
            foreach(Component.Component cmp in components)
            {
                if(cmp is T)
                {
                    return (T)cmp;
                }
            }
            return null;
        }

        public void RemoveComponent<T>() where T : Main.Component.Component
        {
            foreach (Component.Component cmp in components)
            {
                if(cmp is T)
                {
                    components.Remove(cmp);
                }
            }

        }

        private void CallComponentsUpdates(GameTime gt)
        {
            foreach (Component.Component cmp in components)
            {
                cmp.Update(gt);
            }
        }
    }
}
