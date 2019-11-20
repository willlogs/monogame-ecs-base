using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Main.Scene
{
    public class Scene : IECSActor
    {
        private List<Entity.Entity> entities;

        public Scene()
        {
            entities = new List<Entity.Entity>();
        }

        public void Update(GameTime gt)
        {
            CallEntitiesUpdates(gt);
        }

        public Entity.Entity AddEntity(Main.Entity.Entity entity)
        {
            entities.Add(entity);
            return entity;
        }

        public void RemoveEntity(Main.Entity.Entity entity)
        {
            entities.Remove(entity);
        }
        private void CallEntitiesUpdates(GameTime gt)
        {
            foreach (Entity.Entity entt in entities)
            {
                entt.Update(gt);
            }
        }
    }
}
