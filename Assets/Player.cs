using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 10f;
    private Rigidbody2D body;
    private Animator anim;
    public AudioClip walkSound;
    public AudioClip jumpSound;
    public AudioSource audioSource;
    private bool isGrounded; // To check if player is on the ground
    private bool isWalking; // To track if Ray is walking
    public GameObject JumpSFXprefab;


    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        // Handle horizontal movement
        float horizontalInput = 0;
        if (Input.GetKey(KeyCode.D))
            horizontalInput = 1;
        else if (Input.GetKey(KeyCode.A))
            horizontalInput = -1;

        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        // Flip player based on direction
        if (horizontalInput < 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput > -0.01f)
            transform.localScale = new Vector3(-1, 1, 1);

        // Handle walking sound
        if (horizontalInput != 0 && isGrounded && !isWalking)
        {
            PlayWalkingSound();
        }
        else if (horizontalInput == 0 || !isGrounded)
        {
            StopWalkingSound();
        }

        // Handle jumping
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            body.velocity = new Vector2(body.velocity.x, jumpForce);
            PlayJumpingSound();
        }

        anim.SetBool("Move", horizontalInput != 0);
    }
    
// Play walking sound
private void PlayWalkingSound()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = walkSound;
            audioSource.loop = true; // Loop the walking sound
            audioSource.Play();
            isWalking = true;
        }
    }

    // Stop walking sound
    private void StopWalkingSound()
    {
        if (audioSource.isPlaying && audioSource.clip == walkSound)
        {
            audioSource.Stop();
            isWalking = false;
        }
    }

    // Play jumping sound
    private void PlayJumpingSound()
    {
        GameObject soundInstance = Instantiate(JumpSFXprefab, transform.position, Quaternion.identity);
        AudioSource audioSource = soundInstance.GetComponent<AudioSource>();
        audioSource.Play();
    }

    // Check if the player is grounded
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
