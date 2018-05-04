using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escena1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnScene()
    {

        SceneManager.LoadScene("pant1");
    }

    public void OnScene1()
    {

        SceneManager.LoadScene("pant2");
    }
  
    public void OnScene4()
    {

        SceneManager.LoadScene("pant2");
    }

    public void OnSceneEcho()
    {

        SceneManager.LoadScene("EchoOp");
    }
    public void OnSceneDistortion()
    {

        SceneManager.LoadScene("DistortionOp");
    }

    public void OnSceneReverb()
    {

        SceneManager.LoadScene("ReverbOp");

    }
        public void OnSceneChorus()
        {

            SceneManager.LoadScene("ChorusOp");
        }

    public void Pant2()
    {

        SceneManager.LoadScene("pant2");
    }
}
