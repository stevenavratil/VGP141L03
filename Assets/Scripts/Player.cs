using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string name;
    public string tag;
    public int level;
    public int score;

    public Player(string playerName, string playerTag, int playerLevel, int playerScore)
    {
        name = playerName;
        tag = playerTag;
        level = playerLevel;
        score = playerScore;
    }
}