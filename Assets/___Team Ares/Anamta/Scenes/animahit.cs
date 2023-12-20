using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class animahit : MonoBehaviour
{

    public Animator AnimaHit;

    void Start()
    {
        // Play the default animation
        PlayDefaultAnimationClip();
    }

    public void PlayDefaultAnimationClip()
    {
        AnimaHit.SetBool("hit", true);
    }
}
