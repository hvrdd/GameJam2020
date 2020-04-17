using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxX, minX;
    
    public float Y;
    public Vector3 myPos;

    public float WaitTime;

    public float newX;

    public float CurrentX;

    public GameObject Object1, Object2, Object3,Object4, ObjectToSpawn;

    public float score;

    public int random;

    private void Start()
    {
        StartCoroutine(Moving());
    }
    public void Update()
    {
        CurrentX = (transform.position.x);
        random = Random.Range(1, 5);
        if(random == 1)
        {
            ObjectToSpawn = Object1;
        }
        else if (random == 2)
        {
            ObjectToSpawn = Object2;
        }
        else if (random == 3)
        {
            ObjectToSpawn = Object3;
        }
        else if (random == 4)
        {
            ObjectToSpawn = Object4;
        }
        
    }



    IEnumerator Moving()
    {
        yield return new WaitForSeconds(WaitTime);
        newX = Random.Range(minX, maxX);
        transform.position = new Vector2(newX, transform.position.y);
        CurrentX = newX;
        if (WaitTime > 1)
        {
            WaitTime -= 0.05f;
        }
        SpawnBall();
        StartCoroutine(Moving());
        
    }

    void SpawnBall()
    {

        Instantiate(ObjectToSpawn, transform.localPosition, Quaternion.identity);

    }

}