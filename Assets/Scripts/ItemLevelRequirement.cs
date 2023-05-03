using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLevelRequirement : MonoBehaviour
{
    PlayerLevelSystem playerLevel;
    private GameObject player;

    [SerializeField] int requiredLevel;

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
                Debug.Log("Item Equiped!");
            }
            else
                Debug.Log("You are to low level!");
        }
    }


}
