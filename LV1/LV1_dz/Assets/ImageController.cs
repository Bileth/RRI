using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    [SerializeField] Text storyText;
    [SerializeField] bool map = false; 
    [SerializeField] bool flag = false; 

    [SerializeField] Image image; 
    [SerializeField] Image image2; 
    [SerializeField] Sprite ringImage; 
    [SerializeField] Sprite necklaceImage; 
    [SerializeField] Sprite bagImage; 
    [SerializeField] Sprite daggerImage; 
    [SerializeField] Sprite mapImage; 
    // Start is called before the first frame update
    void Start()
    {
        image.enabled = false;
        image2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(map){
            image2.sprite = mapImage;

            if(!image.enabled && !flag){
                image2.enabled = true;
                flag = true;
            }
        }
        if(storyText.text.Contains("necklace")){
            image.sprite = necklaceImage;
            image.enabled = true;
        }
        else if(storyText.text.Contains("ring")){
            image.sprite = ringImage;
            image.enabled = true;
        }
        else if(storyText.text.Contains("bag")){
            image.sprite = bagImage;
            image.enabled = true;
        }
        else if(storyText.text.Contains("dagger")){
            image.sprite = daggerImage;
            image.enabled = true;
        }   
        else if(storyText.text.Contains("map")){
            image.sprite = mapImage;
            image.enabled = true;
            map = true; 
        }
        else if(storyText.text.Contains("made it out")){
            image2.enabled = false;
        }
        else{
            image.enabled = false;
        }
    }
}
