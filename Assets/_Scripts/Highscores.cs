using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highscores : MonoBehaviour
{
    //These are used to store the highscores between the scens, as we are also using a odn't destroy so the script will carry over from scene
    //to scene.
    public float highscore1;
    public float highscore2;
    public float highscore3;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
