using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class ScoreManager : MonoBehaviour
{

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        //Find the gameobject called "Timer" and then finds the Script called "Timer". And then it finds and runs the commad stopTimer.
        GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().stopTimer();

    }
}
