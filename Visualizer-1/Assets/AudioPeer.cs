using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class AudioPeer: MonoBehaviour {
    AudioSource audio;

    public static float[] _samples = new float[512];
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        GetSpectrumAudioSource();
	}

    void GetSpectrumAudioSource()
    {
        audio.GetSpectrumData(_samples, 0, FFTWindow.Blackman);
    }
}
