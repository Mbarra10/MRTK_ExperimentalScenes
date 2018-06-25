﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    private Animator _handAnimator;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start () {
        _handAnimator = GetComponent<Animator>();
	}

    public void HandGrab(bool grab)
    {
        if (_handAnimator == null)
        {
            return;
        }

        _handAnimator.SetBool("Grab", grab);
    }

    public void OnTriggerEnter(Collider collider)
    {
        GameObject collectible = collider.gameObject;

        if (collectible.tag == "Collectible")
        {
            if (collectible.name == "SciFiGun")
            {
                Debug.Log("Has collided with gun");
            }
        }
    }
}
