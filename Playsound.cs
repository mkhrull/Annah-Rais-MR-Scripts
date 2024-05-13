using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playsound : MonoBehaviour
{
    public AudioSource audio;

    public void playButton()
    {
        audio.Play();
    }
}
