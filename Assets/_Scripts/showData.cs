using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showData : MonoBehaviour
{
    public Text playerNameText;
    public Text roundsToPlayText;
    public Text ballSpeedText;
    public Text rotationSpeedText;
    

    private void Awake()
    {
        playerNameText.text = keepData.PlayerName;
        roundsToPlayText.text = "Rounds: " + keepData.RoundsToPlay.ToString();
        ballSpeedText.text = "Ball Speed: " + keepData.BallSpeedMultiplier.ToString();
        rotationSpeedText.text = "Cube Rotation: " + keepData.CubeRotationMultiplier.ToString();
        //scoreText.text = PlayerController.Score.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
       // scoreText.text = PlayerController.Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        playerNameText.text = keepData.PlayerName;
        roundsToPlayText.text = "Rounds: " + keepData.RoundsToPlay.ToString();
        ballSpeedText.text = "Ball Speed: " + keepData.BallSpeedMultiplier.ToString();
        rotationSpeedText.text = "Cube Rotation: " + keepData.CubeRotationMultiplier.ToString();
        //scoreText.text = PlayerController.Score.ToString();
    }

}
