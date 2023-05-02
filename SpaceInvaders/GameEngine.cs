using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class GameEngine
    {
        private bool isNotOver;

        private SceneRenderer sceneRenderer;

        private Scene scene;

        private GameSettings gameSettings;

        private static GameEngine gameEngine;

        private GameEngine()
        {
            
        }

        public static GameEngine GetGameEngine(GameSettings gameSettings)
        {
            if (gameEngine == null) 
            { 
                gameEngine = new GameEngine(gameSettings);
            }
            return gameEngine;
        }

        private GameEngine(GameSettings gameSettings)
        {
            this.gameSettings = gameSettings;
            isNotOver = true;
            scene = Scene.GetScene(gameSettings);
            sceneRenderer = new SceneRenderer(gameSettings);
        }

        public void Run()
        {
            do
            {
                sceneRenderer.ClearScreen();
                sceneRenderer.Render(scene);

                Thread.Sleep(gameSettings.GameSpeed);
            }
            while (isNotOver);

        }
    }
}
