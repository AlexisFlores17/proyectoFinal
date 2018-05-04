using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sliders : MonoBehaviour {

    public Slider Delay;
    public Slider DecayRatio;
    public Slider WetMix;
    public Slider DryMix;

   
   // Use this for initialization


    void Start() {

    }

    // Update is called once per frame
    void Update() {

        Delay.GetComponent<Slider>().value = PlayerPrefs.GetFloat("DelayEcho");
        DecayRatio.GetComponent<Slider>().value = PlayerPrefs.GetFloat("DecayEcho");
        WetMix.GetComponent<Slider>().value = PlayerPrefs.GetFloat("WetEcho");
        DryMix.GetComponent<Slider>().value = PlayerPrefs.GetFloat("DryEcho");
    }

   

    public void SliderDelayEcho() {


      //  Debug.Log(slider1.value);

        PlayerPrefs.SetFloat("DelayEcho", Delay.value);

    }

    public void SliderDecayEcho()
    {


        //  Debug.Log(slider1.value);

      

        PlayerPrefs.SetFloat("DecayEcho", DecayRatio.value);

    }



    public void SliderWetEcho()
    {


        //  Debug.Log(slider1.value);



        PlayerPrefs.SetFloat("WetEcho", WetMix.value);

       
    }


    public void SliderDryEcho()
    {


        //  Debug.Log(slider1.value);

     

        PlayerPrefs.SetFloat("DryEcho", DryMix.value);
    }
}
