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
       // animationHandler.PlayTargetAnimation();
    }


    public void HandleHeavyAttack()
    {

    }
}
