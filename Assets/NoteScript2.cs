using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Note2")
        {
            Success();
        }
        else if (collision.gameObject.tag == "Note1")
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

