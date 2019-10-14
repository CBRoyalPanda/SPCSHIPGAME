using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon2Movement : MonoBehaviour
{
    public Transform target;
    private Vector3 movementVector = Vector3.zero;
    public float moveSpeed = 1f; //units per second

    void Start()
    {
        target.position = GameObject.Find("starShip").transform.position;
        // or whatever function triggers the movement
        movementVector = (target.position - transform.position).normalized * moveSpeed;
    }

    void Update()
    {
        transform.position += movementVector * Time.deltaTime;
    }
}