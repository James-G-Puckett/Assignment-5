using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keepData : MonoBehaviour
{
    public static string PlayerName = "Player name";
    
    public static int RoundsToPlay = 0;
    public static float BallSpeedMultiplier = 1.0f;
    public static float CubeRotationMultiplier = 1.0f;
    public static int Currentscore = 0;
    public static int HighScore = 0;

    public InputField playerName;
    public Dropdown roundsToPlay;
    public Slider ballSpeedMultiplier;
    public Slider cubeRotationMultiplier;
    public Text showPlayerName;
    
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        showPlayerName.text = PlayerName;
    }

    // Update is called once per frame
    public void UpdateName()
    {
        PlayerName = playerName.text;
        showPlayerName.text = PlayerName;
    }
   
    public void SetRoundsToPlay()
    {
        switch (roundsToPlay.value)
        {
            case 1:
                RoundsToPlay = 1;
                break;
            case 2:
                RoundsToPlay = 2;
                break;
            case 3:
                RoundsToPlay = 3;
                break;
            case 4:
                RoundsToPlay = 4;
                break;
            default:
                RoundsToPlay = 0;
                break;
        }
    }
    public void SetPlayerSpeedMultiplier()
    {
        BallSpeedMultiplier = ballSpeedMultiplier.value;
    }
    public void SetCubeRotationMultiplier()
    {
        CubeRotationMultiplier = cubeRotationMultiplier.value;
    }
}
