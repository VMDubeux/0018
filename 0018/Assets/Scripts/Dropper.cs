using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using System.Globalization;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;
    MeshRenderer renderer;
    Rigidbody rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
    }

    private void Update()
    {
        Debug.Log($"Game time: {Time.time.ToString("F0", CultureInfo.InvariantCulture)}.");
        if (Time.time >= timeToWait) 
        {
            rigidbody.useGravity = true;
            renderer.enabled = true;
        }
    }
}
