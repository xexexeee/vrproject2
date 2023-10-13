using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScript : MonoBehaviour
{
    public Text CounterText;
    public CollisionScript CapsuleScript;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CounterText.text = "Score: " + CapsuleScript.score;
    }
}
