using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopScript : MonoBehaviour
{
    public GameObject dna;
    public Transform spawnPoint;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("trackda"))
        {
            Instantiate(dna, spawnPoint.position, spawnPoint.rotation);
        }
    }
}