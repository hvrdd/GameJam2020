using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Falling : MonoBehaviour
{
    public float amp;
    public float freq;
    float offset;
    int missedObjects;
    private void Start()
    {
        offset = transform.position.x;
    }

    private void Update()
    {
        print(missedObjects);
        var sin = Mathf.Sin(Time.time * freq) * amp;
        transform.position = new Vector3(sin + offset, transform.position.y, transform.position.z);
       
            if (missedObjects >= 5)
        {
            SceneManager.LoadScene(1);
        }
    }
    private void OnCollisionEnter2D(Collision2D hit)
    {
        if(hit.gameObject.tag == "Bot")
        {
            missedObjects +=1;
            Destroy(gameObject);
        }
    }
}
