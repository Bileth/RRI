using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioClip BG;
    private AudioSource audio1;
    bool playSound = false;
    void Start()
    {
        audio1 = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    { 
        audio1.volume = 0.1f; 
        audio1.clip = BG;
        if(!playSound)
        audio1.Play(); 
        playSound=true; 
    }
}
