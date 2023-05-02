using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class PlayerShipFactory : GameObjectFactory
    {
        public PlayerShipFactory(GameSettings gameSettings)
            : base(gameSettings)
        {
        }

        public override GameObject GetGameObject(Vector2 position)
        {
            GameObject playerShip = new PlayerShip() { GameObjectTexture = GameSettings.PlayerShip, Position = position, GameObjectType = GameObjectType.PlayerShip };

            return playerShip;
        }

        public GameObject GetGameObject()
        {
            Vector2 position = new Vector2() { X = GameSettings.PlayerStartCoordinates.X, Y = GameSettings.PlayerStartCoordinates.Y };
            GameObject playerShip = GetGameObject(position);

            return playerShip;
        }
    }
}
