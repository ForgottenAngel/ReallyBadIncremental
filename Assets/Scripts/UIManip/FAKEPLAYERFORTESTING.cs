using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using BreakInfinity;
using Character;
using Combat;
using HPBar;

public class FAKEPLAYERFORTESTING : MonoBehaviour 
{
    public hpBarManager hpb;

    characterHandler hptesting = new characterHandler();
    combatHandler combat = new combatHandler();

    // Start is called before the first frame update
    void Awake()
    {
        hpb.maxHpSet(hptesting.derivedStats._maxHP);
    }
    
    // Update is called once per frame
    void Update()
    {
        // Theoretical Combat Loop
        if (Input.GetKeyDown(KeyCode.S))
        {
            combat.spawnEnemy(0);
        } else if (Input.GetKeyDown(KeyCode.A))
        {
            combat.doAbility(hptesting, combat.enemy.abilityList[0], true);
        } else if (Input.GetKeyDown(KeyCode.H))
        {
            combat.doAbility(hptesting, hptesting.abilityList[1], false);
        }

        // Check for dead enemy
        if (combat.checkEnemyAlive() == false)
        {
            hptesting.incrementEXP(combat.enemy._exp);
        }

        hpb.currHpSet(hptesting.derivedStats._currHP);
    }
}
