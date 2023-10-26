using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public Transform Target;
    public float Speed = 1f;

    void Update()
    {
        transform.position += Vector3.left * Speed *Time.deltaTime;
    }
}
