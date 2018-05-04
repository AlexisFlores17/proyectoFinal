using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderDist : MonoBehaviour {

    public Slider DistLevel;
    // Use this for initialization
    void Start () {
        DistLevel.GetComponent<Slider>().value = PlayerPrefs.GetFloat("Dist");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SliderDistLevel()
    {


        //  Debug.Log(slider1.value);

        PlayerPrefs.SetFloat("Dist", DistLevel.value);

    }
}
