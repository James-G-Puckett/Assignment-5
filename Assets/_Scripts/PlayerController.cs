using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // may not be necessary
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public static int Score;
    public float speed = 800.0f;
    public Text scoreText;
    public Text winText;
    private int count = 0;

    public AudioClip cubeSound;
    private AudioSource audioSource;

    private void Awake()
    { 
        this.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        audioSource = GetComponent<AudioSource>();
        //count = Score;

    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");// capitalization matters
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //here is where the ball speed is modified using keepData.BallSpeedMultiplier
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime*keepData.BallSpeedMultiplier);
        //rigidbody refers to the rigidbody component that the script is attached to
        // addforce makes the object with the rigidbody move

    }
    private void OnTriggerEnter(Collider other) // when the ball/player enters a trigger collider
    {
        if(other.gameObject.tag == "Pickup") // if the object has a tag of "Pickup"
        {
            other.gameObject.SetActive(false); // set the object inactive - hide it.
            count += 1; // count increases each time we pick up a cube
            scoreText.text = "Score: " + count; //updates the score on the text field
            Score = count;
            audioSource.PlayOneShot(cubeSound);
            if (keepData.HighScore< keepData.Currentscore)
            {
                keepData.HighScore = keepData.Currentscore;
            }
            if (count >= 8)
                winText.gameObject.SetActive(true);
        }
    }
}
