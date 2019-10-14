using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManage : MonoBehaviour
{
    public bool EnemiesOn = true;

    GameObject[] spawnPoints;
    GameObject currentPoint;
    int index;

    public float timeTillNextSpawn;
    public float RandomEnemyType;

    public GameObject TheMoon;
    public GameObject Sinistar;
    public Vector3 SpawnLocation;
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 0);
        //Instantiate(TheMoon, position, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
            EnemyControl();
        
    }

    void EnemyControl()
    {
        //Chooses a random spawn point
        spawnPoints = GameObject.FindGameObjectsWithTag("point");
        index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];

        //Sets the spawning vector equal to the gameobjects location
        print(currentPoint.name);
        SpawnLocation = currentPoint.transform.position;

        //Determines what enemy will spawn
        RandomEnemyType = Random.value;

        if (RandomEnemyType >= 0.25)
        {
            //spawns the asteroid at the active spawn point
            Instantiate(TheMoon, SpawnLocation, Quaternion.identity);

        }
        else if (RandomEnemyType < 0.25)
        {
            //spawns the asteroid at the active spawn point
            Instantiate(Sinistar, SpawnLocation, Quaternion.identity);

        }


        //This is SUPPOSED to wait 5 seconds until the next asteroid spawns
        StartCoroutine(WaitForFive());
    }

    IEnumerator WaitForFive()
    {
        //Dont know why this isnt working
        yield return new WaitForSeconds(5);

    }
    
}

