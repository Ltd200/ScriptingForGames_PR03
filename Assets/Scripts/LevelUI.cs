using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUI : MonoBehaviour
{
    /*
     private Text levelText;
     private Image expBarImage;
     private PlayerLevelSystem playerLevelSystem;

     private void Awake()
     {
         levelText = transform.Find("levelText").GetComponent<Text>();
         expBarImage = transform.Find("LevelBar").Find("expBar").GetComponent<Image>();
     }

     private void SetExperienceBarSize(float experienceNormalized)
     {
         expBarImage.fillAmount = experienceNormalized;

     }

     private void SetLevelNumber(int levelNumber)
     {
         levelText.text = "Level " + (levelNumber + 1);
     }

     public void SetLevelSystem(PlayerLevelSystem playerLevelSystem)
     {
         this.playerLevelSystem = playerLevelSystem;

         SetLevelNumber(playerLevelSystem.GetLevelNumber());
         SetExperienceBarSize(playerLevelSystem.GetExperienceNormalized());

         playerLevelSystem.OnExperienceChanged += PlayerLevelSystem_OnLevelChanged;
     }

     private void PlayerLevelSystem_OnLevelChanged(object sender, System.EventArgs e) //updates level number
     {
         SetLevelNumber(playerLevelSystem.GetLevelNumber());
     }

     private void PlayerLevelSystem_OnExperienceChanged(object sender, System.EventArgs e) //updates exp bar
     {
         SetExperienceBarSize(playerLevelSystem.GetExperienceNormalized());
 }
    */
}



