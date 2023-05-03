using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GainEXP : MonoBehaviour
{
    
    [Header("EXP Given")]
    
    [SerializeField] float BaseExp;
    [SerializeField] float ExpMultiplier; 

    
    
    private GameObject player;
    PlayerLevelSystem playerLevel;


    private void Start() //Refrence the players level up script
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerLevel = player.GetComponent<PlayerLevelSystem>();
    }

    private void Update() //Simple way of adding xp
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerLevel.GainExp(BaseExp * ExpMultiplier); /*Take this function, along with the GameObject, PlayerLevelSystem, and the assignment
                                                            in void start. You can then add exp to the player in your own scripts */
                                                            
        }
    }
}
