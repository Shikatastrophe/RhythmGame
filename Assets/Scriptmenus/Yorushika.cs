using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Yorushika : MonoBehaviour
{
    // Start is called before the first frame update
    public void lvlselect()
    {
        SceneManager.LoadScene("Evening Calm, Somewhere, Fireworks");
    }

    public void Asphyxia()
    {
        SceneManager.LoadScene("Asphyxia");
    }
}
