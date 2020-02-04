using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CuadroInterfaz1 : MonoBehaviour, ITrackableEventHandler {

    public GameObject canvas;
    public GameObject boton1;
    public GameObject boton2;
    public GameObject boton3;
    public GameObject boton4;
    public GameObject boton5;
    public GameObject boton6;

    public AudioSource audio;

   private TrackableBehaviour mTrackableBehaviour;

    void Start()
    {

        canvas.SetActive(false);
        boton1.SetActive(false);
        boton2.SetActive(false);
        boton3.SetActive(false);
        boton4.SetActive(false);
        boton5.SetActive(false);
        boton6.SetActive(false);



		mTrackableBehaviour = GetComponent<TrackableBehaviour>();

        if (mTrackableBehaviour)
        {
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }
    
    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
			// Play audio when target is found
			audio = GetComponent<AudioSource>();
            audio.Play();
            canvas.SetActive(true);
            boton1.SetActive(true);
            boton2.SetActive(true);
        }
        else
        {
			// Stop audio when target is lost
			audio.Stop();
            canvas.SetActive(false);
            boton1.SetActive(false);
            boton2.SetActive(false);
        }
    }
}
