﻿using UnityEngine;
using UnityEngine.UI;

public class PlayerLevelHandler : MonoBehaviour
{
    public bool loopcontrol;
    public Bat batController;
    public LevelSystem playerLevelSytem;
    public Text questRequirements;
    public Text Finish;
    public GameObject Level2EnerenceSign;
    // Start is called before the first frame update
    void Start()
    {
        loopcontrol = true;



    }


    void FixedUpdate()
    {
        if (batController.enemyHealtSystem.GetHealth() <= 1 && loopcontrol == true)
        {
            playerLevelSytem.AddExperience(batController.expAmount);
            questRequirements.text = "Bat Killed : 1  Dziekujemy!";
            Finish.text = "QUEST FINISHED!";
            Finish.color = Color.green;
            Level2EnerenceSign.SetActive(false);

            loopcontrol = false;
        }
    }
}
