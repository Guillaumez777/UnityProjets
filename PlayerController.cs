using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public int speed = 7, jump = 300;
    public bool isGrounded = false;
    private bool isJumping = false;
    private Animator Anim;
    public AudioClip soundJump, soundDead;
    private AudioSource Audio;

	void Start () {
        Anim = GetComponent<Animator>();
        Audio = GetComponent<AudioSource>();
	}
	
	void Update () {
        float h = Input.GetAxis("Horizontal");
        // Déplacement de gauche a droite
        transform.Translate(Vector2.right * h * speed * Time.deltaTime);

        if (h > 0) GetComponent<SpriteRenderer>().flipX = false; Anim.SetBool("walk", true);
        if (h < 0) GetComponent<SpriteRenderer>().flipX = true; Anim.SetBool("walk", true);
        if (h == 0) Anim.SetBool("walk", false);
        if (Input.GetKeyDown(KeyCode.O)) { playerDead(); }

    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            // Son du jump
            Audio.PlayOneShot(soundJump);
            // Saut du perso
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jump * Time.deltaTime;
            Anim.SetTrigger("jump");
            Anim.SetBool("walk", false);
        }

    }

    public void playerDead()
    {
        Anim.SetTrigger("dead");
        Audio.PlayOneShot(soundDead);
    }


}