using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {
    //reference to Spsawn Point//
    [SerializeField] Transform spawnPoint;

    void OnCollisionEnter2D(Collision2D col)
    {
        //This will define if the Empty box collider colided with the "Player" tag//
        if(col.transform.CompareTag("Player"))
            col.transform.position = spawnPoint.position;
    }
}



