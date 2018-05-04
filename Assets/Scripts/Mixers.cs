using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class Mixers : MonoBehaviour {


    public Toggle echo;
    public Toggle distortion;
    public Toggle reverb;
    public Toggle chorus;
 

    // AudioMixerGroup output;
    // Use this for initialization
    void Start () {



       
    }
	
	// Update is called once per frame

     void Update() {


 
        }
    

    public void ButtoEcho()
    {


        if (echo.GetComponent<Toggle>().isOn == true)
        {

            GetComponent<AudioEchoFilter>().enabled = true;
        }
        if (echo.GetComponent<Toggle>().isOn == false)
        {

            GetComponent<AudioEchoFilter>().enabled = false;
        }
    }
    public void ButtonDistortion()
    {

        if (distortion.GetComponent<Toggle>().isOn == true)
        {

            GetComponent<AudioDistortionFilter>().enabled = true;
        }
        if (distortion.GetComponent<Toggle>().isOn == false)
        {

            GetComponent<AudioDistortionFilter>().enabled = false;
        }

    }
    public void ButtonReverb()
    {
        if (reverb.GetComponent<Toggle>().isOn == true)
        {

            GetComponent<AudioReverbFilter>().enabled = true;
        }
        if (reverb.GetComponent<Toggle>().isOn == false)
        {

            GetComponent<AudioReverbFilter>().enabled = false;
        }

    }



    public void ButtonChorus()
    {
        if (chorus.GetComponent<Toggle>().isOn == true) {

            GetComponent<AudioChorusFilter>().enabled = true;
        }
        if (chorus.GetComponent<Toggle>().isOn == false)
        {

            GetComponent<AudioChorusFilter>().enabled = false;
        }


    }



}
