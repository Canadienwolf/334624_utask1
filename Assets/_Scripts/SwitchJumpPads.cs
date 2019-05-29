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
        GameObject.Find("A").GetComponent<JumpPadTrigger_01>().enabled = false;
        GameObject.Find("A").GetComponent<BoxCollider>().enabled = false;
        color = GetComponentInChildren<MeshRenderer>();
        color.material.color = Color.gray;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        ChangeColorBlack();

        GameObject.Find("A").GetComponent<JumpPadTrigger_01>().enabled = true;
        GameObject.Find("A").GetComponent<BoxCollider>().enabled = true;

        TriggerCount = true;
    }

    private void OnTriggerExit(Collider collider)
    {
        Invoke("resetTimer", timer);
    }

    private void ChangeColorBlack()
    {
        color = GetComponentInChildren<MeshRenderer>();
        color.material.color = Color.cyan;
    }

    private void resetTimer()
    {
        TriggerCount = false;
        GameObject.Find("A").GetComponent<JumpPadTrigger_01>().enabled = false;
        GameObject.Find("A").GetComponent<BoxCollider>().enabled = false;
        color.material.color = Color.gray;
    }
}
