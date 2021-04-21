using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using BreakInfinity;
using Character;
using HPBar;

public class FAKEPLAYERFORTESTING : MonoBehaviour 
{
    public hpBarManager hpb;

    characterHandler hptesting = new characterHandler();
    BigDouble fakeplayerchealth;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
     fakeplayerchealth = hptesting.derivedStats._maxHP;
     hpb.maxHpSet(fakeplayerchealth);
    }
    
// Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (fakeplayerchealth > 0)
            fakeplayerchealth -= 20;
        }

        hpb.currHpSet(fakeplayerchealth);
    }
}
