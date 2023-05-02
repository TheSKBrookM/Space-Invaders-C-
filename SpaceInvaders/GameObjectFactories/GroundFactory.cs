using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class GroundFactory : GameObjectFactory
    {
        public GroundFactory(GameSettings gameSettings)
            : base(gameSettings)
        {

        }

        public override GameObject GetGameObject(Vector2 position)
        {
            GameObject ground = new GroundGameObject() { GameObjectTexture = GameSettings.Ground, Position = position, GameObjectType = GameObjectType.GroundObject };

            return ground;
        }

        public List<GameObject> GetGround()
        {
            List<GameObject> ground = new List<GameObject>();

            int startX = GameSettings.GroundStartCoordinates.X;
            int startY = GameSettings.GroundStartCoordinates.Y;

            for (int y = 0; y < GameSettings.NumberOfGroundRows; y++)
            {
                for (int x = 0; x < GameSettings.NumberOfGroundCollumns; x++)
                {
                    Vector2 postition = new Vector2() { X = startX + x, Y = startY + y };
                    GameObject groundObject = GetGameObject(postition);
                    ground.Add(groundObject);
                }
            }
            return ground;
        }
    }
}
