using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    public GameObject capsule;

    public void PressButton()
    {
        if (capsule.active == false)
            capsule.SetActive(true);
        else
            capsule.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

    }
}
