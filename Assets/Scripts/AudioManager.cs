using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
        foreach(Sound s in sounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.audioClip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.Loop;
        }
    }

    private void Start() {
        Play("MainTheme");
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(string name){
        Sound s = Array.Find(sounds, sound => sound.Name == name);
        if(s != null){
            s.source.Play();
        }
    }
}
