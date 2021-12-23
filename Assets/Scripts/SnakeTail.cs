using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{
    public Transform ShakeHead;
    private List<Transform> _snakeCircle = new List<Transform>();
    private List<Vector3> _position = new List<Vector3>();

    private void Start()
    {
        _position.Add(ShakeHead.position);
    }
}
