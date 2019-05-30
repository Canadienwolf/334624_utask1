using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class Timer : MonoBehaviour
{
    public bool timerStart = false;
    public Text timerText;

    private float secondsCount;
    private int minuteCount;
    private int hourCount;
    private GameObject player;
    public int count;

    void Start()
    {
        //Find the gameobject with the tag player
        player = GameObject.FindGameObjectWithTag("Player");

        //Here it ifind the gameobject with the tag "Player" before it proceed to find the script on him called ThirdPersonControl and deactivates the script
        player.GetComponent<ThirdPersonUserControl>().enabled = false;

        //Sets the timerStart bool to false
        timerStart = false;

        StartCoroutine(Countdown(4));
    }

    // Update is called once per frame
    void Update()
    {

        if (timerStart == true)
        {
            Debug.Log("Wut?");
            UpdateTimerUI();
        }
    }

    public void UpdateTimerUI()
    {
        secondsCount += Time.deltaTime;
        timerText.text = hourCount + "h:" + minuteCount + "m:" + (int)secondsCount + "s";
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            hourCount++;
            minuteCount = 0;
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

        
        player.GetComponent<ThirdPersonUserControl>().enabled = true;
    }
}
