using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript2 : MonoBehaviour
{

    public GameObject NotaA;
    public GameObject NotaB;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == NotaA)
        {
            Success();
        }
        else if (collision.gameObject == NotaB)
        {
            Fail();
        }
    }

    private void Success()
    {
        Debug.Log("Gaming");
    }

    private void Fail()
    {
        Debug.Log("Fail");
    }
}
