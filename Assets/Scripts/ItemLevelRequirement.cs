using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLevelRequirement : MonoBehaviour
{
    PlayerLevelSystem playerLevel;
    private GameObject player;

    
    [Header("Level Requirement Specifications")]
    [SerializeField] int requiredLevel;
    public bool canBeEquipped;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerLevel = player.GetComponent<PlayerLevelSystem>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (playerLevel.level >= requiredLevel)
            {
                Debug.Log("This item can be equiped!");
                canBeEquipped = true;
            }
            else
                Debug.Log("You are to low level to equipe this item!");
                canBeEquipped = false;
        }
    }


}
