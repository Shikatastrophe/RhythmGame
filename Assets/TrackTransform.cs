using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackTransform : MonoBehaviour
{
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = GlobalVar.trackSpeed;
        Debug.Log(speed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
