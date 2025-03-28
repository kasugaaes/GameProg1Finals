//Game Manager

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [Header("Quest Related")]
    public int questID; //this identifies what quest is currently active

    [Header("UI Elements")]
    public Text txtMonologue; //this is referenced to the ui text for player monologue
    public Text txtQuestUpdate; //this is referenced to the ui text for quest display


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (questID)
        {
            case 1:
                txtQuestUpdate.text = "Get your backpack from your house.";
                break;
            case 2:
                txtQuestUpdate.text = "Find the box containing your map.";
                break;
            case 3:
                txtQuestUpdate.text = "Continue on!";
                break;
            default:
                txtQuestUpdate.text = "";
                break;
        }
    }
}