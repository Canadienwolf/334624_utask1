using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScene()
    {
        //Tells the game to change the scene to level_select
        SceneManager.LoadScene("Level_Select");
    }

    public void startLevel_1()
    {
        //Tells the game to change the scene to Level_1
        SceneManager.LoadScene("Level_1");
    }

    public void startLevel_2()
    {
        //Tells the game to change the scene to Level_2
        SceneManager.LoadScene("Level_2");
    }

    public void startLevel_3()
    {
        //Tells the game to change the scene to Level_3
        SceneManager.LoadScene("Level_3");
    }


}
