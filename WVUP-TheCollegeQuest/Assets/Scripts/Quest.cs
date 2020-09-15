using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[Serializable]
public class Quest : MonoBehaviour
{

    public String QuestInfo
    {
        get;
        set;
    }
    public String QuestTitle
    {
        get;
        set;
    }
    public bool IsCompleted
    {
        get;
        set;
    }

    public int EXP
    {
        get;
        set;
    }
    
    public Quest(String NewQuestTitle, String NewQuestInfo, int newEXP)
    {
        IsCompleted = false;
        QuestInfo = NewQuestInfo;
        QuestTitle = NewQuestTitle;
        EXP = newEXP;


    }




   
}
