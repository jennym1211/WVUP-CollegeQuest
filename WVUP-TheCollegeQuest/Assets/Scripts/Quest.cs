// ***********************************************************************
// Assembly         : Assembly-CSharp
// Author           : Jennifer
// Created          : 08-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 09-14-2020
// ***********************************************************************
// <copyright file="Quest.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary>Quests are what the user is supposed to fulfill to progress throughout their college quest.</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

/// <summary>
/// The model class that represents the Quest data.
/// Implements the <see cref="UnityEngine.MonoBehaviour" />
/// </summary>
/// <seealso cref="UnityEngine.MonoBehaviour" />
[Serializable]
public class Quest
{
    /// <summary>
    /// Gets or sets the quest information.
    /// </summary>
    /// <value>The quest information.</value>
    public String QuestInfo
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets the quest title.
    /// </summary>
    /// <value>The quest title.</value>
    public String QuestTitle
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is completed.
    /// </summary>
    /// <value><c>true</c> if this instance is completed; otherwise, <c>false</c>.</value>
    public bool IsCompleted
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets the exp.
    /// </summary>
    /// <value>The exp.</value>
    public int EXP
    {
        get;
        set;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Quest"/> class.
    /// </summary>
    /// <param name="NewQuestTitle">Creates new questtitle.</param>
    /// <param name="NewQuestInfo">Creates new questinfo.</param>
    /// <param name="newEXP">The new exp.</param>
    public Quest(String NewQuestTitle, String NewQuestInfo, int newEXP)
    {
        IsCompleted = false;
        QuestInfo = NewQuestInfo;
        QuestTitle = NewQuestTitle;
        EXP = newEXP;
    }
}