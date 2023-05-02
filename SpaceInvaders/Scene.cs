using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Scene
    {
        public List<GameObject> swarm;
        public List<GameObject> ground;

        public GameObject playerShip;

        public List<GameObject> playerShipMissile;

        private GameSettings gameSettings;

        private static Scene scene;

        private Scene()
        {

        }

        private Scene(GameSettings gameSettings)
        {
            this.gameSettings = gameSettings;

            swarm = new AlienShipFactory(this.gameSettings).GetSwarm();
            ground = new GroundFactory(this.gameSettings).GetGround();
            playerShip = new PlayerShipFactory(this.gameSettings).GetGameObject();
            playerShipMissile = new List<GameObject>();
        }

        public static Scene GetScene(GameSettings gameSettings)
        {
            if (scene == null)
            {
                scene = new Scene(gameSettings);
            }
            return scene;
        }
    }
}
