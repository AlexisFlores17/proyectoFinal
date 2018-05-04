using UnityEngine;
using System.IO;
using System.Collections;

public class Files2 : MonoBehaviour
{
    private FileInfo[] info;
    private DirectoryInfo dir;
    private string aaa = "/mnt/sdcard/music";
    public AudioSource audio;
    void Start()
    {
        dir = new DirectoryInfo(aaa);
        info = dir.GetFiles("*.mp3");
        foreach (FileInfo f in info) ;
    }

    public int k = 0;

    void OnGUI()
    {
        GUI.Button(new Rect(10, 60, 400, 30), Application.dataPath);

        for (int i = 0; i <= info.Length - 1; i++)
        {
            if (GUI.Button(new Rect(10, 10 + 40 * i, 200, 30), info[i].Name))
            {
                WWW mus = new WWW("file:///" + info[i].FullName);
                audio.clip = mus.GetAudioClip(true, true);
                Debug.Log("file:///" + info[i].FullName);
                audio.Play();
                k = i;
            }
        }

        GUI.TextField(new Rect(100, 400, 600, 40), "file:///" + info[k].FullName);
    }
}