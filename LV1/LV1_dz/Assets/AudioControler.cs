using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class AudioControler : MonoBehaviour
{
    [SerializeField] Text storyText;
    [SerializeField] AudioClip BG;

    [SerializeField] AudioClip mapSound; 
    [SerializeField] AudioClip escape; 

    [SerializeField] AudioClip tresureSound;

    AudioSource audio1;
    bool playSound = false;

    // Start is called before the first frame update
    void Start()
    {
        audio1 = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        bool uvjet1 = storyText.text.Contains("bag") || storyText.text.Contains("ring") || storyText.text.Contains("dagger") || storyText.text.Contains("necklace");
        if(uvjet1){
            playSound=false;
            audio1.volume = 0.5f; 
            audio1.clip = tresureSound;
            if(!audio1.isPlaying)
                audio1.Play(); 
        }
        else if(storyText.text.Contains("map")){
            playSound=false;
            audio1.volume = 1f; 
            audio1.clip = mapSound;
            if(!audio1.isPlaying)
                audio1.Play(); 
        }   
        else if(storyText.text.Contains("made it out")){
            audio1.clip = escape;
            audio1.volume = 0.2f; 
            if(!audio1.isPlaying)
                audio1.Play(); 
        }
        else{
            audio1.volume = 0.1f; 
            audio1.clip = BG;
            if(!playSound)
                audio1.Play(); 
            playSound=true; 
        }
    }
}
