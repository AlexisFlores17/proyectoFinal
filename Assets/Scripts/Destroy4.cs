using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy4 : MonoBehaviour {

    public static Destroy4 ObjetoEstado;
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
}
