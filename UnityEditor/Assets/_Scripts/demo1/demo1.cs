﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.EditorTools;

[AddComponentMenu("Managers/demo1")]
public class demo1 : MonoBehaviour
{
    [Header("武器")]
    public int weapon;
    public int ammunition;
    public int aurability;

    [Tooltip("玩家的名字，肯定不再是JOJO对吧")]
    public string playerName;

    [Space]
    public int health = 100;

    [Range(0, 1000)]
    public int exp = 0;

    [Pixeye.Unity.Foldout("Enemys")]
    public GameObject a, b, c, d, e;

    [SerializeField]
    private int coins;

    [HideInInspector]
    public int maxHealth = 100;

    [TextArea]
    public string gameDescribe = "";

    private void OnValidate()
    {
        if (health < 0)
        {
            Debug.LogError("生命值不可为负");
            health = 0;
        }        
        else if (health > 100)
        {
            Debug.LogError("生命值不可超过最大值 " + maxHealth);          
            health = 100;
        }        
    }

    [ContextMenu("显示当前生命值")]
    public void PrintHealth()
    {
        Debug.Log("Health = " + health);
    }
}