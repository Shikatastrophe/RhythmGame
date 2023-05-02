using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class bar : MonoBehaviour
{
    public GameObject barr;
    public float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        AnimateBar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimateBar()
    {
        LeanTween.scaleX(barr, 1, time);
    }
}
