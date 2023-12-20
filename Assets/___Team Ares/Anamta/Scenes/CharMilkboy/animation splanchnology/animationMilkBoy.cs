using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class animationMilkBoy : MonoBehaviour
{
    public Animator bottle;
    public Animator drink;

    public bool isBottleAnimationDone = false;

    private float timer = 0f;

    void Start()
    {
        // Play the default animation
        PlayDefaultAnimationClip();
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3f && !isBottleAnimationDone)
        {
            PlayMilkDrinkingAnimation();
            isBottleAnimationDone = true;
        }
    }

    private void PlayMilkDrinkingAnimation()
    {
        drink.SetBool("Drink", true);
    }

    void PlayDefaultAnimationClip()
    {
        // Play bottle animation
        bottle.SetBool("Bottle", true);
    }
}
