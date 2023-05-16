using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private float points;
    private TextMeshProUGUI textmesh;
    // Start is called before the first frame update
    void Start()
    {
        textmesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textmesh.text = points.ToString("0");
    }

    public void PointAdd(float point)
    {
        points += point;
    }
}
