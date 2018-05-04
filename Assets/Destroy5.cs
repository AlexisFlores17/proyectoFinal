using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy5 : MonoBehaviour
{

    public static Destroy5 ObjetoEstado;
    // Use this for initialization

    void Awake()
    {

        if (ObjetoEstado == null)
        {
            ObjetoEstado = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (ObjetoEstado != this)
        {
            Destroy(gameObject);
        }

    }

    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name != "1")
        {
          //  gameObject.GetComponent<Canvas>().targetDisplay = 1;
            gameObject.GetComponent<Canvas>().enabled = false;
        }
    
    }
}
