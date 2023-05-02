using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class PlayerShipMissileFactory : GameObjectFactory
    {
        public PlayerShipMissileFactory(GameSettings gameSettings)
            : base(gameSettings)
        {

        }


        public override GameObject GetGameObject(Vector2 position)
        {
            GameObject missile = new PlayerShipMissile() { GameObjectTexture = GameSettings.PlayerMissile, Position = position, GameObjectType = GameObjectType.PlayerShipMissile };

            return missile;
        }

        //public List<GameObject> GetGround()
        //{
        //    List<GameObject> missile = new List<GameObject>();

        //    for (int y = 0; y < GameSettings.NumberOfGroundRows; y++)
        //    {
        //        for (int x = 0; x < GameSettings.NumberOfGroundCollumns; x++)
        //        {
        //            GameObject missileObject = GetGameObject(new Vector2(GameSettings.GroundStartCoordinates.X, GameSettings.GroundStartCoordinates.Y));
        //            missile.Add(missileObject);
        //        }
        //    }
        //    return missile;
        //}
    }
}
