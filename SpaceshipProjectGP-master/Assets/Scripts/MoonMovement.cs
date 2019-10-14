using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class MoonMovement : MonoBehaviour
{
    public float speed = 20f;
    public Transform target;
    public Vector3 TargetPosition = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        //Destroys the object 5 seconds after it has spawned
        Destroy(gameObject, 5);

        //Finds the current location of the player
        TargetPosition = GameObject.Find("starShip").transform.position;
        



    }

    // Update is called once per frame
    void Update()
    {
        //Moves towards the player at a changeable speed
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, TargetPosition, step);

      

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //When the object colides with anything the object is destroyed
        Destroy(gameObject);
    }
}
