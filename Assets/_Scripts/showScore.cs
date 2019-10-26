using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showScore : MonoBehaviour
{
    public Text lastScoreText;
    public Text highScoreText;
    public int temp;
    public int highscore;
    private void Awake()
    {
        lastScoreText.text = PlayerController.Score.ToString();
        highScoreText.text = PlayerController.Score.ToString();
        temp = PlayerController.Score;
        if (temp > PlayerController.Score)
            highscore = temp;
        else
            highscore = PlayerController.Score;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
