using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy2 : MonoBehaviour {

    public static Destroy2 ObjetoEstado;
    // Use this for initialization
   

    void Awake()
    {
        Scene scene = SceneManager.GetActiveScene();
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
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {

        Scene scene = SceneManager.GetActiveScene();


        if (scene.name == "pant1")
        {
         //   gameObject.GetComponent<Canvas>().targetDisplay = 0;
            gameObject.GetComponent<Canvas>().enabled = true;
        }
        if (scene.name == "2")
        {
         //   gameObject.GetComponent<Canvas>().targetDisplay = 1;
            gameObject.GetComponent<Canvas>().enabled = false;
        }
        if (scene.name == "1")
        {
         //   gameObject.GetComponent<Canvas>().targetDisplay = 1;
            gameObject.GetComponent<Canvas>().enabled = false;
        }

        if (scene.name == "pant2")
        {
         //   gameObject.GetComponent<Canvas>().targetDisplay = 1;
            gameObject.GetComponent<Canvas>().enabled = false;
        }
        if (scene.name == "pant1")
        {
            //   gameObject.GetComponent<Canvas>().targetDisplay = 1;
           // gameObject.GetComponent<Canvas>().enabled = false;
        }


    }
}
