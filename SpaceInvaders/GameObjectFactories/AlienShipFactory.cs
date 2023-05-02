using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class AlienShipFactory : GameObjectFactory
    {
        // приводимось до базових налаштувань GameObjectFactory
        public AlienShipFactory(GameSettings gameSettings)
            : base(gameSettings)
        {

        }

        // створюємо об'єкт з потрібними параметрами

        public override GameObject GetGameObject(Vector2 position)
        {
            GameObject alienShip = new AlienShip() { GameObjectTexture = GameSettings.AlienShip, Position = position, GameObjectType = GameObjectType.AlienShip };

            return alienShip;
        }

        // створюємо та заповнюємо фабрику потрібною кількістью
        public List<GameObject> GetSwarm()
        {
            List<GameObject> swarm = new List<GameObject>();

            int startX = GameSettings.SwarmStartCoordinates.X;
            int startY = GameSettings.SwarmStartCoordinates.Y;

            for (int y = 0; y < GameSettings.NumberOfSwarmRows; y++)
            {
                for (int x = 0; x < GameSettings.NumberOfSwarmCollumns; x++)
                {
                    Vector2 postition = new Vector2() { X = startX + x, Y = startY + y };
                    GameObject alienShip = GetGameObject(postition);
                    swarm.Add(alienShip);
                }
            }
            return swarm;
        }
    }
}
