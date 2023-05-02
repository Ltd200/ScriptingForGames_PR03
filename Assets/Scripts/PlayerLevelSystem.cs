using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevelSystem
{
    private int level;
    private int exp;
    private int expToNextLevel;

    [SerializeField] ParticleSystem LevelUpEffect;
    [SerializeField] AudioSource LevelUpSound;

    public PlayerLevelSystem()
    {
        level = 0;
        exp = 0;
        expToNextLevel = 100;
    }

    public void AddExp(int amount)
    {
        exp += amount;
        if(exp >= expToNextLevel) //Level Up
        {
            level++;
            exp -= expToNextLevel;

        }
    }
}
