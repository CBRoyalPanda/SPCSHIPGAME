using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float speed = 5f;
    public float turnSpeed = 50f;

    public GameObject laserBeam;
    public GameObject Spawnbox;

    public Vector3 LaserSpawnPointLoc;

    // Start is called before the first frame update
    void Start()
    {
        LaserSpawnPointLoc = Spawnbox.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Allows the player to move forwards
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        //Allows the player to move backwards
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        //Allows the player to turn right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * turnSpeed);
        }

        //Allows the player to turn left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * turnSpeed);
        }

        //Allows the player to fire a laser
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LaserSpawnPointLoc = Spawnbox.transform.position;
            Instantiate(laserBeam, LaserSpawnPointLoc, Quaternion.identity);
        }
    }
    //Destroys player on colision with any box colider
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
