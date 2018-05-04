using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderReverb : MonoBehaviour {


    public Slider DryLevel;
    public Slider Room;
    public Slider DecayTime;
    public Slider ReflectionLevel;
    public Slider ReflectionDelay;
    public Slider ReverbLevel;
    public Slider ReverbDelay;

    // Use this for initialization
    void Start () {

        DryLevel.GetComponent<Slider>().value = PlayerPrefs.GetFloat("DryLevel");
        Room.GetComponent<Slider>().value = PlayerPrefs.GetFloat("Room");
        DecayTime.GetComponent<Slider>().value = PlayerPrefs.GetFloat("DecayTimeReverb");
        ReflectionLevel.GetComponent<Slider>().value = PlayerPrefs.GetFloat("ReflectionLevel");
        ReflectionDelay.GetComponent<Slider>().value = PlayerPrefs.GetFloat("ReflectionDelay");
        ReverbLevel.GetComponent<Slider>().value = PlayerPrefs.GetFloat("ReverbLevel");
        ReverbDelay.GetComponent<Slider>().value = PlayerPrefs.GetFloat("ReverbDelay");

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SliderDryLevel()
    {


        //  Debug.Log(slider1.value);

        PlayerPrefs.SetFloat("DryLevel", DryLevel.value);

    }

    public void SliderRoom()
    {


        //  Debug.Log(slider1.value);



        PlayerPrefs.SetFloat("Room", Room.value);

    }



    public void SliderDecayTime()
    {


        //  Debug.Log(slider1.value);



        PlayerPrefs.SetFloat("DecayTimeReverb", DecayTime.value);


    }


    public void SliderReflectionLevel()
    {


        //  Debug.Log(slider1.value);



        PlayerPrefs.SetFloat("ReflectionLevel", ReflectionLevel.value);
    }

    public void SliderReflectionDelay()
    {


        //  Debug.Log(slider1.value);

        PlayerPrefs.SetFloat("ReflectionDelay", ReflectionDelay.value);


    }
    public void SliderReverbLevel()
    {


        //  Debug.Log(slider1.value);



        PlayerPrefs.SetFloat("ReverbLevel", ReverbLevel.value);

    }



    public void SliderReverbDelay()
    {


        //  Debug.Log(slider1.value);



        PlayerPrefs.SetFloat("ReverbDelay", ReverbDelay.value);


    }


    
}
