using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerLevelSystem : MonoBehaviour
{
    [Header("Level Information")]
    public int level;
    public float currentEXP;
    public float requiredEXP;

    [Header("UI")]
    [SerializeField] Image expBar;
    [SerializeField] TextMeshProUGUI LevelText;



    private void Start()
    {
        expBar.fillAmount = currentEXP / requiredEXP;
    }

    private void Update()
    {
        UpdateUI();
        if(currentEXP >= requiredEXP)
        {
            LevelUp();
        }
    }

    private void UpdateUI() //Updates UI to reflect level on screen
    {
        float expFraction = currentEXP / requiredEXP;
        expBar.fillAmount = expFraction;
        LevelText.text = "Level " + level;
    }

    public void GainExp(float amountGained)
    {
        currentEXP += amountGained;
    }

    public void LevelUp() //Attactch level up logic here
    {
        level++;
        expBar.fillAmount = 0f;
        currentEXP = Mathf.RoundToInt(currentEXP - requiredEXP);
    }
}
