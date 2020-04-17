using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public float amp;
    public float freq;
    float offset;
    private void Start()
    {
        offset = transform.position.x;
    }

    private void Update()
    {
        var sin = Mathf.Sin(Time.time * freq) * amp;
        transform.position = new Vector3(sin + offset, transform.position.y, transform.position.z);
        if(transform.position.y <= -6f)
        {
            Destroy(gameObject);
        }
    }
}
