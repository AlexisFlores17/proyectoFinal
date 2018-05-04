using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {


    public static Destroy ObjetoEstado;
    // Use this for initialization

    void Awake()
    {

          if (ObjetoEstado == null)
        {
          ObjetoEstado = this;
        DontDestroyOnLoad(gameObject);
        }
        else if (ObjetoEstado != this) {
          Destroy(gameObject);
        }

    }


    void Start() {

        }

        // Update is called once per frame
        void Update() {

        }
    

}
