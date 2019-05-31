using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text HighScoreLevel_1;
    public Text HighScoreLevel_2;
    public Text HighScoreLevel_3;

    public bool timerStart = false;
    public Text timerText;
    public Text highscore;
    float score;

    public bool menu;

    private float secondsCount;
    private int minuteCount;
    private int hourCount;
    private GameObject player;
    public int count;

    void Start()
    {



        if (!menu)
        {
            //Find the gameobject with the tag player
            player = GameObject.FindGameObjectWithTag("Player");

            //Here it finds the gameobject with the tag "Player" before it proceed to find the script on him called ThirdPersonControl and deactivates the script
            player.GetComponent<ThirdPersonUserControl>().enabled = false;

            highscore.text = PlayerPrefs.GetString("HighScoreLevel_" + (GameObject.Find("GameController").GetComponent<GameController>().level - 1));
            StartCoroutine(Countdown(4));
        }
        else
        {
            HighScoreLevel_1.text = PlayerPrefs.GetString("HighScoreLevel_1s", "--");
            HighScoreLevel_2.text = PlayerPrefs.GetString("HighScoreLevel_2s", "--");
            HighScoreLevel_3.text = PlayerPrefs.GetString("HighScoreLevel_3s", "--");
        }

        //Sets the timerStart bool to false
        timerStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if timer is active, then start the command called UpdateTimerUI
        if (timerStart == true)
        {
            UpdateTimerUI();
            
        }

        //Says that score should be the same as minuteCount + secondsCount;
        score = minuteCount + secondsCount;

        GameObject.Find("Highscore (1)").GetComponent<Text>().text = score.ToString();

    }

    public void UpdateTimerUI()
    {
        secondsCount += Time.deltaTime;
        timerText.text = minuteCount + "m:" + (int)secondsCount + "s";

        //Says that is there is 60 seconds in the timer, it should change to one minute and make the second counter go back to 0 again.
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
    }

    IEnumerator Countdown(int seconds)
    {
        
        int count = seconds;

        while (count > 0)
        {
            yield return new WaitForSeconds(1);
            count--;
            timerText.text = count.ToString();
        }
        timerText.text = "GO!";
        yield return new WaitForSeconds(1);
        timerStart = true;

        //Enables the ThirdPersonUseControl script on the player again
        player.GetComponent<ThirdPersonUserControl>().enabled = true;
    }

    public void stopTimer()
    {
        timerStart = false;

        GameObject ScoreSaver = GameObject.Find("ScoreSaver");

        if (ScoreSaver.GetComponent<Highscores>().highscore1 >= score && SceneManager.GetActiveScene().name == "Level_1" && ScoreSaver.GetComponent<Highscores>().highscore1 != 0)
        {
            GameObject.Find("ScoreSaver").GetComponent<Highscores>().highscore1 = score;
        }

        if (ScoreSaver.GetComponent<Highscores>().highscore2 >= score && SceneManager.GetActiveScene().name == "Level_1" && ScoreSaver.GetComponent<Highscores>().highscore2 != 0)
        {
            GameObject.Find("ScoreSaver").GetComponent<Highscores>().highscore2 = score;
        }

        if (ScoreSaver.GetComponent<Highscores>().highscore3 >= score && SceneManager.GetActiveScene().name == "Level_1" && ScoreSaver.GetComponent<Highscores>().highscore3 != 0)
        {
            GameObject.Find("ScoreSaver").GetComponent<Highscores>().highscore3 = score;
        }

        //here we tried to make the PlayerPrefs for storing the highscores for the playthroughs, but were unsuccessful at doing this.
        /*if (PlayerPrefs.GetFloat("HighScoreLevel_1") >= score)
        {
            PlayerPrefs.SetString("HighScoreLevel_1", score.ToString());
            //PlayerPrefs.SetFloat("HighScoreLevel_1" + score, minuteCount + secondsCount);
            Debug.Log("save1");
        }

        if (PlayerPrefs.GetFloat("HighScoreLevel_2f") >= minuteCount + secondsCount && SceneManager.GetActiveScene().name == "Level_2" || PlayerPrefs.GetFloat("HighScoreLevel_2f") != 0)
        {
            PlayerPrefs.SetString("HighScoreLevel_2s", minuteCount + " " + secondsCount);
            PlayerPrefs.SetFloat("HighScoreLevel_2f", minuteCount + secondsCount);
            Debug.Log("save2");
        }

        if (PlayerPrefs.GetFloat("HighScoreLevel_3f") >= minuteCount + secondsCount && SceneManager.GetActiveScene().name == "Level_3" || PlayerPrefs.GetFloat("HighScoreLevel_3f") != 0)
        {
            PlayerPrefs.SetString("HighScoreLevel_3s", minuteCount + " " + secondsCount);
            PlayerPrefs.SetFloat("HighScoreLevel_3f", minuteCount + secondsCount);
            Debug.Log("save3");
        }
        */

        ///Tells the game to run a command called ReturnToMainMenu.
        StartCoroutine(ReturnToMainMenu());
        
    }

    IEnumerator ReturnToMainMenu()
    {
        //Tells the game to wait for 3 seconds before returning the game to the mainscene.
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainScene");
    }


}
