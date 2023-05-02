using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    abstract class GameObjectFactory
    {
        public GameSettings GameSettings { get; set; }

        public abstract GameObject GetGameObject(Vector2 position);

        public GameObjectFactory(GameSettings gameSettings)
        {
            GameSettings = gameSettings;
        }


    }
}
