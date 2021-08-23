﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "bossData", menuName = "Boss Data", order = 1)]
public class BossData : ScriptableObject
{
    [Header("Base Stats")]
    public float health;
    [Range(0, 100)]
    public float resistance;
    public float meleeAttackRange;
    public float weaponDamage;
    public float aoeRadius;

    [Header("AI Stats")]
    [Tooltip("How long it takes in seconds for the boss to stop closing the distance.")]
    public float patience;

}
