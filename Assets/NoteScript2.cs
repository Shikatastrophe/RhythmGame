using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript2 : MonoBehaviour
{
    // You don't need these arrays anymore
    // public GameObject[] note1;
    // public GameObject[] note2;

    // Use OnTriggerEnter2D() instead of OnCollisionEnter2D()
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Note2"))
        {
            Success(other);
        }
        else if (other.CompareTag("Note1"))
        {
            Fail(other);
        }
    }

    private void Success(Collider2D other)
    {
        Debug.Log("Gaming");
        // Use other.gameObject.GetComponent<Animator>() instead of note2[0].GetComponent<Animator>()
        other.gameObject.GetComponent<Animator>().SetTrigger("succ");
        Destroy(other.gameObject.GetComponent<CircleCollider2D>());
    }

    private void Fail(Collider2D other)
    {
        Debug.Log("Fail");
        // Use other.gameObject.GetComponent<Animator>() instead of note1[0].GetComponent<Animator>()
        other.gameObject.GetComponent<Animator>().SetTrigger("fail");
        Destroy(other.gameObject.GetComponent<CircleCollider2D>());
    }
}