using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;
using System.IO;
using UnityEngine.Networking;
using System;

public class SongManager : MonoBehaviour
{
    public static SongManager Instance;
    public AudioSource audioSource;
    public float songDelayInSeconds;

    public string fileLocation;
    public float noteTime;
    public float noteSpawnY;

    public static MidiFile midiFile;


    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        ReadFile();
    }

    private void ReadFile()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
