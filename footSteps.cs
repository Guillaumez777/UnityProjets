using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footSteps : MonoBehaviour {

    public AudioClip SoundFootSteps;
    private AudioSource Audio;
    public float PitchMin = 1.0f, PitchMax = 1.5f, VolMin = 0.2f, VolMax = 0.5f;

	void Start ()
    {
        Audio = GetComponent<AudioSource>();
    }
	
	
	void Update ()
    {
        
        if (Input.GetAxis("Horizontal") != 0)
        {
            if (!Audio.isPlaying && transform.parent.GetComponent<PlayerController>().isGrounded)
            {
                Audio.pitch = Random.Range(PitchMin, PitchMax);
                Audio.volume = Random.Range(VolMin, VolMax);
                Audio.PlayOneShot(SoundFootSteps); 
            }
           
        }


	}
}
