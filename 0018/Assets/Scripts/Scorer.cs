using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    //Player

    int hits = 0;
    private void OnCollisionEnter(Collision collided)
    {
        if (collided.gameObject.tag == "Unhitted")
        {
            hits++;
            Debug.Log($"You've bumped into a thing this many times: {hits}");
        }
    }
}
