using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPadTrigger_01 : MonoBehaviour
{

    public Transform startMarker;
    public Transform endMarker;

    private float speed = 5f;
    private float startTime;
    private float journeyLength;
    private bool isAirborne;
    private GameObject player;
    private Renderer color;

    // Start is called before the first frame update
    void Start()
    {
        //Finds the renderer on the child object so that i am able to change the values in it
        color = GetComponentInChildren<MeshRenderer>();

        //Here i tell the code to change the value that changes the color on the gameobject
        color.material.color = Color.magenta;

        //Find the gameobject with the tag player
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if (isAirborne == true)
        {
            float distCovered = (Time.time - startTime) * speed;

            float fracJourney = distCovered / journeyLength;

            player.transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
        }

        if (player.transform.position == endMarker.transform.position)
        {
            //Here it tells that the gameobject is not airborne anymore and thereby turns of the command that is happening when the gameobject is airborn
            isAirborne = false;

            GameObject.FindGameObjectWithTag("Player").GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled = true;
        }
    }

    //Tells an action to happen when something gets into the trigger
    private void OnTriggerEnter(Collider other)
    {
        startTime = Time.time;

        //Here it finds the distance between the startmarker position and the endmarker position
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);

        //Here it turns the bool to true and tells the code that the gameobject is now airborne, and thereby triggers the if airborne command
        isAirborne = true;

        GameObject.FindGameObjectWithTag("Player").GetComponent <UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled = false;

    }



}
