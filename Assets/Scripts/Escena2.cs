using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escena2 : MonoBehaviour
{

    public void OnScene4()
    {

        SceneManager.LoadScene("pant2");
    }

    public void OnSceneEcho()
    {

        SceneManager.LoadScene("EchoOp2");
    }
    public void OnSceneDistortion()
    {

        SceneManager.LoadScene("DistortionOp2");
    }

    public void OnSceneReverb()
    {

        SceneManager.LoadScene("ReverbOp2");

    }
    public void OnSceneChorus()
    {

        SceneManager.LoadScene("ChorusOp2");
    }
}
