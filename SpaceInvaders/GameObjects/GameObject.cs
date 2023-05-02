using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    abstract class GameObject
    {
        public Vector2 Position { get; set; }

        public char GameObjectTexture { get; set; }

        public GameObjectType GameObjectType { get; set; }
    }
}
