using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //Player

    [SerializeField] float moveSpeed = 5f;
    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move with WASD or arrows keys.");
        Debug.Log("Dodge all the obstacles and reach the peaceful zone.");
    }

    void MovePlayer() 
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
