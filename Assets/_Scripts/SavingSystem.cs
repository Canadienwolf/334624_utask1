using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SavinSystem : MonoBehaviour
{
    public Text HighScoreLevel_1;
    public Text HighScoreLevel_2;
    public Text HighScoreLevel_3;

    private Text TimerText;

    void Start()
    {
        //Find the gameobject with the tag "Timer" and gets the script called inside it called "Timer" and gets the line timerText
        TimerText = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().timerText;

    }

            void Update()
        {
            //Says that the command inside the if, should only happen if the active scene is level_1
            if (SceneManager.GetActiveScene().name == "Level_1")
            {
                //Says that the highscore text should be the same as timertext
                HighScoreLevel_1.text = TimerText.text;
            }

        //Says that the command inside the if, should only happen if the active scene is level_2
        if (SceneManager.GetActiveScene().name == "Level_2")
            {
            //Says that the highscore text should be the same as timertext
            HighScoreLevel_2.text = TimerText.text;
            }

        //Says that the command inside the if, should only happen if the active scene is level_3
        if (SceneManager.GetActiveScene().name == "Level_3")
            {
                //Says that the highscore text should be the same as timertext
                HighScoreLevel_3.text = TimerText.text;
            }
        }

}
