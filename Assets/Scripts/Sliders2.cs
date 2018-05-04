using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliders2 : MonoBehaviour {

    public Slider slider2;
    float valorEcho2;

   
    // Use this for initialization

  

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        slider2.GetComponent<Slider>().value = PlayerPrefs.GetFloat("Delay2");
    }



    public void SliderP2()
    {
        Debug.Log(slider2.value);
        PlayerPrefs.SetFloat("Delay2", slider2.value);
    }
}
