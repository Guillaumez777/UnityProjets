using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGroundedScript : MonoBehaviour {

    public AudioClip soundGround;
    private AudioSource Audio;

    void Start()
    {
        Audio = GetComponent<AudioSource> ();
    }

    void OnTriggerEnter2D (Collider2D col) {
        transform.parent.GetComponent<PlayerController>().isGrounded = true;
        Audio.PlayOneShot(soundGround);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        transform.parent.GetComponent<PlayerController>().isGrounded = false;
    }

}
