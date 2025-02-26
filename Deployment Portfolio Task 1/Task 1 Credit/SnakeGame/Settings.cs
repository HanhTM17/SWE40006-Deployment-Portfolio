﻿//Coding Reference: https://www.mooict.com/c-tutorial-create-a-classic-snake-game-in-visual-studio/

namespace SnakeGame
{
    public enum Directions
    {
        Left,
        Right,
        Up,
        Down
    };
    class Settings
    {
        public static int Width { get; set; } 
        public static int Height { get; set; } 
        public static int Speed { get; set; } 
        public static int Score { get; set; } 
        public static int Points { get; set; } 
        public static bool GameOver { get; set; } 
        public static Directions direction { get; set; } 
        public Settings()
        {
            Width = 16;
            Height = 16;
            Speed = 10;
            Score = 0;
            Points = 1;
            GameOver = false;
            direction = Directions.Down;
        }
    }
}