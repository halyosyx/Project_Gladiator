using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacking : MonoBehaviour
{
    AnimationHandler animationHandler;

    private void Awake()
    {
        animationHandler = GetComponentInChildren<AnimationHandler>();
    }
    public void HandleLightAttack()
    {
       animationHandler.PlayTargetAnimation("H_Light_Attack_1", true);
    }


    public void HandleHeavyAttack()
    {
        animationHandler.PlayTargetAnimation("H_Heavy_Attack_1", true);
    }
}
