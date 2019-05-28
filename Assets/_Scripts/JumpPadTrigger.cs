using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPadTrigger : MonoBehaviour
{

    public List<GameObject> JumpPads;
    private Renderer color;

    // Start is called before the first frame update
    void Start()
    {
        color = GetComponentInChildren<MeshRenderer>();
        color.material.color = Color.magenta;

        foreach (Transform child in transform)
        {
            if (child.tag == "JumpPad")
            {
                JumpPads.Add(child.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
