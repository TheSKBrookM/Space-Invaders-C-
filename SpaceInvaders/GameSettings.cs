using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class GameSettings
    {
        // Console Settings
        public int ConsoleWidth { get; set; } = 80;
        public int ConsoleHeight { get; set; } = 30;

        // Swarm settings
        public int NumberOfSwarmRows { get; set; } = 2;
        public int NumberOfSwarmCollumns { get; set; } = 60;
        public Vector2 SwarmStartCoordinates { get; set; } = new Vector2() { X = 10, Y = 2 };
        public char AlienShip { get; set; } = 'O';
        public int SwarmSpeed { get; set; } = 20;

        // Player settings
        public Vector2 PlayerStartCoordinates { get; set; } = new Vector2() { X = 40, Y = 19 };
        public char PlayerShip { get; set; } = '^';

        // Ground settings
        public Vector2 GroundStartCoordinates { get; set; } = new Vector2() { X = 1, Y = 20 };
        public char Ground { get; set; } = 'П';
        public int NumberOfGroundRows { get; set; } = 1;
        public int NumberOfGroundCollumns { get; set; } = 80;

        // Player missile settings
        public char PlayerMissile { get; set; } = '|';
        public int PLayerMissileSpeed { get; set; } = 5;

        // Game Settings
        public int GameSpeed { get; set; } = 100;
    }
}
