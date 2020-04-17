using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrScore : MonoBehaviour
{
    //Thiss int keeps track of all the plastic waste that is clogging upp the ocean. It should increase whenever a plastic object hits the ground.
    [Header("Amount of plastic that has hit the ocean floor")]
    [Tooltip("This int keeps track of how many plastic objects that has hit the ocean floor. It increases with each instance.")]
    public int aggregatedPlastic;
    // Start is called before the first frame update
    void Start()
    {
        //Set the plastic to 0 whenever the game starts
        aggregatedPlastic = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TrashHitsTheOceanFloor()
    {
        //Increases the aggregatedplastic score with 1.
        aggregatedPlastic += 1;
    }
}
