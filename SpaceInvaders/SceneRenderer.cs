using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class SceneRenderer
    {
        private int screenWidth;
        private int screenHeight;

        private char[,] screenMatrix;

        public SceneRenderer(GameSettings gameSettings)
        {
            screenWidth = gameSettings.ConsoleWidth;
            screenHeight = gameSettings.ConsoleHeight;
            screenMatrix = new char[gameSettings.ConsoleHeight, gameSettings.ConsoleWidth];

            Console.WindowHeight = gameSettings.ConsoleHeight;
            Console.WindowWidth = gameSettings.ConsoleWidth;
            Console.SetBufferSize(screenWidth, screenHeight);

            Console.CursorVisible = false;
            SetCursorZero();
        }

        public void Render(Scene scene) 
        {
            SetCursorZero();

            AddListForRenderer(scene.swarm);
            AddListForRenderer(scene.ground);
            AddListForRenderer(scene.playerShipMissile);

            AddGameObjectForRenderer(scene.playerShip);

            StringBuilder stringBuilder = new StringBuilder();

            for (int y = 0; y < screenHeight; y++)
            {
                for (int x = 0; x < screenWidth; x++) 
                {
                    stringBuilder.Append(screenMatrix[y, x]);
                }
                stringBuilder.Append(Environment.NewLine);
            }

            Console.WriteLine(stringBuilder.ToString());
            SetCursorZero();
        }

        public void AddGameObjectForRenderer(GameObject gameObject)
        {
            if (gameObject.Position.Y < screenMatrix.GetLength(0) &&
                gameObject.Position.X < screenMatrix.GetLength(1))
            {
                screenMatrix[gameObject.Position.Y, gameObject.Position.X] = gameObject.GameObjectTexture;
            }
            else
            {
              // screenMatrix[gameObject.Position.Y, gameObject.Position.X] = ' ';
            }
        }

        public void AddListForRenderer(List<GameObject> gameObjects)
        {
            foreach (GameObject gameObject in gameObjects) 
            {
                AddGameObjectForRenderer(gameObject);
            }
        }

        public void ClearScreen()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int y = 0; y < screenHeight; y++)
            {
                for (int x = 0; x < screenWidth; x++)
                {
                    stringBuilder.Append(' ' );
                }
                stringBuilder.Append(Environment.NewLine);
            }

            Console.WriteLine(stringBuilder.ToString());

        }

        private void SetCursorZero()
        {
            Console.SetCursorPosition(0, 0);
        }
    }
}
