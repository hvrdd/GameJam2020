using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToDestroy : MonoBehaviour
{
    public GameObject Particle;

    private void Update()
    {
        Instantiate(Particle,transform.position, Quaternion.identity);
        StartCoroutine(ParticleDestroy());
    }
    IEnumerator ParticleDestroy()
    {
        yield return new WaitForSeconds(.5f);
        Destroy(this);

    }
}
