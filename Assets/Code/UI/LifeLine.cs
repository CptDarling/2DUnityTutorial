﻿using UnityEngine;

/// <summary>
/// This component will kill its GameObject when the 
/// number of lives remaining drops below the selected value.
/// </summary>
public class LifeLine : PlayerDeathMonoBehaviour
{
  [SerializeField]
  int lifeCount = 1;

  protected void Start()
  {
    if(GameController.instance.lifeCount < lifeCount)
    {
      Destroy(gameObject);
    }
  }

  public override void OnPlayerDeath()
  {
    if(GameController.instance.lifeCount < lifeCount)
    {
      DeathEffectManager.PlayDeathEffectsThenDestroy(gameObject);
    }
  }
}