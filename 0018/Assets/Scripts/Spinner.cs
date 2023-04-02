using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    //Obstacle Rotater

    [SerializeField] float y = 0.45f;

    void Update()
    {
        transform.Rotate(0, y, 0);
    }
}
