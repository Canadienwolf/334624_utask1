using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class ScoreManager : MonoBehaviour
{
    public GameObject Canvas;
    public Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        //new WaitForSeconds(2);
        //timer = gameObject.GetComponent<Timer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        //timer = Canvas.GetComponentInChildren<Timer>().timerStart;
    }
}
