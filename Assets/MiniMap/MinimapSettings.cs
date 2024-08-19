using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapSettings : MonoBehaviour
{
    public Transform targetToFollow;
    public bool rotateWithTarget = true;

    private void Start()
    {
        targetToFollow = GameObject.Find("PlayerCapsule").transform;
    }
}
