using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grabar : MonoBehaviour

{
   

    private bool micConnected = false;
    private int minFreq;
    private int maxFreq;
    private AudioSource goAudioSource;
    public Toggle grabar;







    void Start()
    {

        if (Microphone.devices.Length <= 0)
        {
            Debug.LogWarning("Microphone not connected!");
        }
        else
        {

            micConnected = true;


            Microphone.GetDeviceCaps(null, out minFreq, out maxFreq);


            if (minFreq == 0 && maxFreq == 0)
            {

                maxFreq = 44100;
            }



            goAudioSource = this.GetComponent<AudioSource>();
        }

      
    }


    public void GrabarButton()
    {

        if (grabar.GetComponent<Toggle>().isOn == true)
        {

            if (micConnected)
            {

                if (!Microphone.IsRecording(null))
                {


                    goAudioSource.clip = Microphone.Start(null, true, 20, maxFreq);
                    //  SavWav.Save("myfile", goAudioSource.clip);
                }

            }
        }
        if (grabar.GetComponent<Toggle>().isOn == false)
        {

            Microphone.End(null);
            // goAudioSource.Play();
            goAudioSource.Stop();
            //  SavWav.Save("myfile", goAudioSource.clip);
        }



    }

    public void StopButton()
    {




   
          goAudioSource.Stop();
     
    }

    public void StopButtonGrabar()
    {




        Microphone.End(null);
        // goAudioSource.Play();
        goAudioSource.Stop();
      //  SavWav.Save("myfile", goAudioSource.clip);
    }

    public void PlayButton()
    {




        goAudioSource.Play();
       
    }


}








