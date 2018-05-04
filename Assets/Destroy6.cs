using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy6 : MonoBehaviour
{

    public static Destroy6 ObjetoEstado;
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

        if (scene.name != "2")
        {


            //gameObject.GetComponent<Canvas>().targetDisplay = 1;
            gameObject.GetComponent<Canvas>().enabled = false;
        }

        if (scene.name == "2")
        {
          //  gameObject.GetComponent<Canvas>().targetDisplay = 0;
            gameObject.GetComponent<Canvas>().enabled = true;
        }
    }
}
