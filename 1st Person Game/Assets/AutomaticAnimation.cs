using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AutomaticAnimation : MonoBehaviour
{
    Rigidbody rb;
    Animator anim;
    Vector3 lastPosition;

    private void Awake()
    {
        lastPosition = transform.position;
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }


}
