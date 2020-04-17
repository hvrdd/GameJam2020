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

    public GameObject Ball;

    public float score;

    private void Start()
    {
        StartCoroutine(Moving());
    }
    public void Update()
    {
        CurrentX = (transform.position.x);
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
        Instantiate(Ball, transform.localPosition, Quaternion.identity);

    }

}