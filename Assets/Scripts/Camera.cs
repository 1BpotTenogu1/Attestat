using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform Target;
    public float SmoothSpeed = 0.125f;
    public float Offset;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Target.position.z + Offset);       
    }
}
