using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComboManagerText : MonoBehaviour
{
    private int comboscore;
    private TextMeshProUGUI textmesh;
    // Start is called before the first frame update
    void Start()
    {
        textmesh = GetComponent<TextMeshProUGUI>();
        comboscore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (comboscore < 5)
        {
            textmesh.text = "";
        }
        else if (comboscore >= 5)
        {
            textmesh.text = "Com¡bo";
        }
    }

    public void ComboAdd()
    {
        comboscore += 1;
    }

    public void ComboReset()
    {
        comboscore = 0;
    }
}