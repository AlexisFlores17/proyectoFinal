using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efectos : MonoBehaviour {


    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        gameObject.GetComponent<AudioEchoFilter>().delay = PlayerPrefs.GetFloat("DelayEcho");
        gameObject.GetComponent<AudioEchoFilter>().decayRatio = PlayerPrefs.GetFloat("DecayEcho");
        gameObject.GetComponent<AudioEchoFilter>().wetMix = PlayerPrefs.GetFloat("WetEcho");
        gameObject.GetComponent<AudioEchoFilter>().dryMix = PlayerPrefs.GetFloat("DryEcho");

        gameObject.GetComponent<AudioDistortionFilter>().distortionLevel = PlayerPrefs.GetFloat("Dist");

        gameObject.GetComponent<AudioReverbFilter>().dryLevel = PlayerPrefs.GetFloat("DryLevel");
        gameObject.GetComponent<AudioReverbFilter>().room = PlayerPrefs.GetFloat("Room");
        gameObject.GetComponent<AudioReverbFilter>().decayTime = PlayerPrefs.GetFloat("DecayTimeReverb");
        gameObject.GetComponent<AudioReverbFilter>().reflectionsLevel = PlayerPrefs.GetFloat("ReflectionLevel");
        gameObject.GetComponent<AudioReverbFilter>().reflectionsDelay = PlayerPrefs.GetFloat("ReflectionDelay");
        gameObject.GetComponent<AudioReverbFilter>().reverbLevel = PlayerPrefs.GetFloat("ReverbLevel");
        gameObject.GetComponent<AudioReverbFilter>().reverbDelay = PlayerPrefs.GetFloat("ReverbDelay");

        gameObject.GetComponent<AudioChorusFilter>().dryMix = PlayerPrefs.GetFloat("DryChorus");
        gameObject.GetComponent<AudioChorusFilter>().delay = PlayerPrefs.GetFloat("DelayChorus");
        gameObject.GetComponent<AudioChorusFilter>().rate = PlayerPrefs.GetFloat("RateChorus");
        gameObject.GetComponent<AudioChorusFilter>().depth = PlayerPrefs.GetFloat("DepthChorus");
    }
}
