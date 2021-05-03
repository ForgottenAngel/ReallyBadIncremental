using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using Character;
using Enemy;
using Combat;

public class gameHandler : MonoBehaviour
{

    public characterHandler player = new characterHandler();
    public  combatHandler combat = new combatHandler();



    void Awake()
    {
        //WE NEED THIS DESPERATELY
        DontDestroyOnLoad(this.gameObject);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
