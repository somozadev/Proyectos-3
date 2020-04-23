﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Abilities/Barbarian/HammerSmashAbility")]
public class HammerSmashAbility : Ability
{
    public int hammerDamage = 20;
    public float hammerRange = 1.5f;
    public float hammerRateAA = 2f;

    public BarbarianController playerController;

    public override void Initialize(GameObject obj) //pasar como ref el obj que tenga el BarbarianController
    {
        playerController = obj.GetComponent<BarbarianController>();
        playerController.attackDamage = hammerDamage;
        playerController.attackRange = hammerRange;
        playerController.attackRate = hammerRateAA;
    }

    public override void TriggerAbility()
    {
        //playerController.funciondelahabilidad();
        playerController.HammerSmash(); 
    }
}
