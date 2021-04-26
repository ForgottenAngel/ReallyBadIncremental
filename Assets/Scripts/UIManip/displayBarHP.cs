using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayBarHP : MonoBehaviour
{

    Text hpl;

    // Start is called before the first frame update
    void Awake()
    {
        hpl = GetComponent<Text> ();
    }

    // Update is called once per frame
    public void textsUpdate(float value)
    {
        hpl.text = "Current Health: " + value;
    }
}
