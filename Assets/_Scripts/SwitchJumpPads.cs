using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchJumpPads : MonoBehaviour
{

    public GameObject JumpPad;
    public bool TriggerCount;

    private Renderer color;
    private float timer = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Tells the script to find a script called "JumpPadTrigger_01 in the gameobject called "A" and deactivate it. 
        GameObject.Find("A").GetComponent<JumpPadTrigger_01>().enabled = false;

        //Tells the script to find a script called "BoxCollider in the gameobject called "A" and deactivate it. 
        GameObject.Find("A").GetComponent<BoxCollider>().enabled = false;

        //Get's the componnet called MeshRenderer in the children.
        color = GetComponentInChildren<MeshRenderer>();

        //Changes the value in the mesh renderer to the values that makes up the color gray.
        color.material.color = Color.gray;


    }

    private void OnTriggerEnter(Collider collider)
    {
        //This function changes the colour back to the colour black.
        ChangeColorBlack();

        //Tells the script to find a script called "JumpPadTrigger_01 in the gameobject called "A" and activate it. 
        GameObject.Find("A").GetComponent<JumpPadTrigger_01>().enabled = true;

        //Tells the script to find a script called "BoxCollider in the gameobject called "A" and activate it.
        GameObject.Find("A").GetComponent<BoxCollider>().enabled = true;

        //Tells the script that it should set the "TriggerCount" bool to true.
        TriggerCount = true;
    }

    //A command that will only rung when something other than the object collides with the trigger of the object the script is placed on.
    private void OnTriggerExit(Collider collider)
    {
        //Tells the code to run the resetTimer command.
        Invoke("resetTimer", timer);
    }

    //This function changes the colour back to the colour black.
    private void ChangeColorBlack()
    {
        //Changes the value in the mesh renderer to the values that makes up the color cyan.
        color.material.color = Color.cyan;
    }

    //A command that is contained in this script only which is called resetTimer.
    private void resetTimer()
    {
        //Tells the script that it should set the "TriggerCount" bool to false.
        TriggerCount = false;

        //Tells the script to find a script called "JumpPadTrigger_01 in the gameobject called "A" and deactivate it.
        GameObject.Find("A").GetComponent<JumpPadTrigger_01>().enabled = false;

        //Tells the script to find a script called "BoxCollider in the gameobject called "A" and deactivate it.
        GameObject.Find("A").GetComponent<BoxCollider>().enabled = false;

        //Changes the value in the mesh renderer to the values that makes up the color gray.
        color.material.color = Color.gray;
    }
}
