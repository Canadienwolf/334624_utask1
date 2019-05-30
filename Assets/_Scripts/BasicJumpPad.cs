using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class BasicJumpPad : MonoBehaviour
{
    private float upForce = 500.0f;
    private float forwardForce = 280.0f;

    void OnTriggerEnter (Collider collider)
    {
        if (collider.tag == "Player")
        {
            //Add force upwards and forward when a gameobject enter the trigger zone, the force up and forward are decided by two private floats.
            collider.GetComponent<Rigidbody>().AddForce(new Vector3(0, upForce, forwardForce));

            //Here i disable the character controller when the character is in the air
            collider.GetComponent<ThirdPersonCharacter>().enabled = false;
            collider.GetComponent<ThirdPersonUserControl>().enabled = false;
        }
    }
}
