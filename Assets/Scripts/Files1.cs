using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor; 
//Activar esto pruebas unity

public class Files1 : MonoBehaviour {

    string path;
    public AudioSource mp3;

    // Use this for initialization

    // Update is called once per frame
    void Update() {

    }

    public void OpenExplorer()
    {
        path = EditorUtility.OpenFilePanel("Overwrite with mp3", "", "mp3");
       //Activar esto pruebas unity
        GetSound();
    }

    void GetSound()
    {
        if (path != null)
        {

            UpdateSound();
        }

    }

    void UpdateSound()
    {
        WWW www = new WWW("file:///" + path);

        mp3.clip = www.GetAudioClip(true,true);
    }

    public void PlayButton(){

        mp3.Play();
}

    public void PauseButton()
    {

        mp3.Pause();
    }

    public void StopButton()
    {

        mp3.Stop();
    }

}
