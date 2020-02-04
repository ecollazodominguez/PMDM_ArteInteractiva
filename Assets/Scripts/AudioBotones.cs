using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class AudioBotones : MonoBehaviour{

public int isPlaying=0;

    public void Start()
 {  
     
         }

    public void action(){
        AudioSource audio = GetComponent<AudioSource>();
        Button b = GetComponent<Button>();
        if(isPlaying == 0){
        isPlaying= 1;
        audio.Play();
        }else{
        isPlaying= 0;
         audio.Stop();
    }

}
}