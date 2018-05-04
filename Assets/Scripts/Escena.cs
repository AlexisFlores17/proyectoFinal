using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escena : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnScene()
    {
        
        SceneManager.LoadScene("2");

    }

    public void OnScene4() {

        SceneManager.LoadScene("Opciones2");

    }
}
