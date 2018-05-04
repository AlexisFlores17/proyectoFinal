using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliderchorus : MonoBehaviour {

    public Slider Dry;
    public Slider Delay;
    public Slider Rate;
    public Slider Depth;

    // Use this for initialization
    void Start () {

        Dry.GetComponent<Slider>().value = PlayerPrefs.GetFloat("DryChorus");
        Delay.GetComponent<Slider>().value = PlayerPrefs.GetFloat("DelayChorus");
        Rate.GetComponent<Slider>().value = PlayerPrefs.GetFloat("RateChorus");
        Depth.GetComponent<Slider>().value = PlayerPrefs.GetFloat("DepthChorus");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SliderDryChorus()
    {


        //  Debug.Log(slider1.value);

        PlayerPrefs.SetFloat("DryChorus", Dry.value);

    }

    public void SliderDelayChorus()
    {


        //  Debug.Log(slider1.value);



        PlayerPrefs.SetFloat("DelayChorus", Delay.value);

    }



    public void SliderRateChorus()
    {


        //  Debug.Log(slider1.value);



        PlayerPrefs.SetFloat("RateChorus", Rate.value);



    }


    public void SliderDepthChorus()
    {


        //  Debug.Log(slider1.value);



        PlayerPrefs.SetFloat("DepthChorus", Depth.value);
    }
}
