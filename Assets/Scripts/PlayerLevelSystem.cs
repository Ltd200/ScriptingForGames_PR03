using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLevelSystem : MonoBehaviour
{
    [Header("Level Information")]
    public int level;
    public float currentEXP;
    public float requiredEXP;

    [Header("UI")]
    [SerializeField] Image expBar;

    private void Start()
    {
        expBar.fillAmount = currentEXP / requiredEXP;
    }

    private void Update()
    {
        UpdateUI();
        if (Input.GetKeyDown(KeyCode.E))
        {
            GainExp(20);
        }
        if(currentEXP >= requiredEXP)
        {
            LevelUp();
        }
    }

    private void UpdateUI()
    {
        float expFraction = currentEXP / requiredEXP;
        expBar.fillAmount = expFraction;
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
