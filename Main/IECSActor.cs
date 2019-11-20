using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Main
{
    public interface IECSActor
    {
        void Update(GameTime gt);
    }
}
