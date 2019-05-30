using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class AntiAirborne : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {

            //Activates the character controller scripts again.
            collider.GetComponent<ThirdPersonUserControl>().enabled = true;
            collider.GetComponent<ThirdPersonCharacter>().enabled = true;
        }
    }
}
