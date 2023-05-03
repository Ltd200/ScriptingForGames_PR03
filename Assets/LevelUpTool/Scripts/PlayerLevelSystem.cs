using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerLevelSystem : MonoBehaviour
{

    private float lerpTimer;
    private float delayTimer;
    
    
    [Header("Level Information")]
    public int level;
    public float currentEXP;
    public float requiredEXP;

    [Header("Level Up Math")]
    [Range(1f,300f)]
    [Tooltip("Adjusts a flat amount how much xp each level needs, this will have a minmal effect")]
    public float additionMultiplier = 300;
    [Range(2f, 4f)]
    [Tooltip("If powerMultiplier is higher lower levels will be closer together in exp values. If lower xp values will be further apart")]
    public float powerMultiplier = 2;
    [Range(7f, 14f)]
    [Tooltip("Lower divisionMultiplier makes the xp graph more of a bell curve, a higher value will make the graph more evenly distributed")]
    public float divisionMultiplier = 7;

    [Header("UI")]
    [SerializeField] Image expBar;
    [SerializeField] Image backexpBar;
    [SerializeField] TextMeshProUGUI LevelText;

    [Header("Effects")]
    [SerializeField] AudioSource LevelUpAudio;



    private void Start()
    {
        expBar.fillAmount = currentEXP / requiredEXP;
        backexpBar.fillAmount = currentEXP / requiredEXP;
        requiredEXP = CalculateEXP();
        LevelText.text = "Level " + level;
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
        float FXP = expBar.fillAmount;
        if(FXP < expFraction)
        {
            delayTimer += Time.deltaTime;
            backexpBar.fillAmount = expFraction;
            if(delayTimer > .5)
            {
                lerpTimer += Time.deltaTime;
                float percentComplete = lerpTimer /4;
                expBar.fillAmount = Mathf.Lerp(FXP, backexpBar.fillAmount, percentComplete);
            }
        }
    }

    public void GainExp(float amountGained)
    {
        currentEXP += amountGained;
    }

    public void LevelUp() //Attactch level up logic here
    {
        level++;
        LevelText.text = "Level " + level;
        expBar.fillAmount = 0f;
        backexpBar.fillAmount = 0f;
        currentEXP = Mathf.RoundToInt(currentEXP - requiredEXP);
        requiredEXP = CalculateEXP();

        AudioSource newSound = Instantiate(LevelUpAudio);
        Destroy(newSound.gameObject, newSound.clip.length);


    }

    private int CalculateEXP()
    {
        int solveForRequiredXp = 0;
        for (int levelCycle = 1; levelCycle <= level; levelCycle++)
        {
            solveForRequiredXp += (int)Mathf.Floor(levelCycle + additionMultiplier * Mathf.Pow(powerMultiplier, levelCycle / divisionMultiplier));
        }
        return solveForRequiredXp / 4;
    }
}
