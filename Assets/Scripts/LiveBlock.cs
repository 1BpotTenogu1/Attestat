using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveBlock : MonoBehaviour
{
    private int _block;
    public TextMesh Text;
    public Display Game;
    public Camera Camera;
    public Snake Snake;

    void Start()
    {
        _block = Random.Range(1, 20);

        Game = FindObjectOfType<Display>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(_block > 0)
        {
            if(collision.collider.TryGetComponent(out Snake snake))
            {
                _block -= 1;
                
            }
        }
    }
}
