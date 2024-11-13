using System;

namespace MathGame.models;

public class Game
{
    public GameType GameType { get; set; }
    public int Score {get; set;}
    // Continue implementation
}

public enum GameType
{
    ADDITION,
    SUBTRACTION,
    MULTIPLICATION,
    DIVISION
}