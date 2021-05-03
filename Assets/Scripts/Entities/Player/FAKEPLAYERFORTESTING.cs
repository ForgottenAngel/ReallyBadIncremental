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
    public hpBarManager hpEnemy;

    GameObject GO;

    // THE ALMIGHTY COPY PASTE >>> GO.GetComponent<gameHandler>()

    // Start is called before the first frame update
    void Awake()
    {
        GO = GameObject.Find("FakePlayer");


        hpb.maxHpSet(GO.GetComponent<gameHandler>().player.derivedStats._maxHP);
        hpEnemy.maxHpSet(GO.GetComponent<gameHandler>().combat.enemy.enemyStats._maxHP);

        hpb.currHpSet(GO.GetComponent<gameHandler>().player.derivedStats._currHP);
        hpEnemy.currHpSet(GO.GetComponent<gameHandler>().combat.enemy.enemyStats._currentHP);

    }
    
    // Update is called once per frame
    void Update()
    {
        // Theoretical combat Loop
        if (Input.GetKeyDown(KeyCode.S))
        {
            GO.GetComponent<gameHandler>().combat.spawnEnemy(0);
            hpEnemy.maxHpSet(GO.GetComponent<gameHandler>().combat.enemy.enemyStats._maxHP);
            Debug.Log("You Spawned an enemy!!");
        } else if (Input.GetKeyDown(KeyCode.A))
        {
            GO.GetComponent<gameHandler>().combat.doAbility(GO.GetComponent<gameHandler>().player, GO.GetComponent<gameHandler>().combat.enemy.abilityList[0], true);
            Debug.Log("The Enemy Throws a rock!!");
        } else if (Input.GetKeyDown(KeyCode.H))
        {
            GO.GetComponent<gameHandler>().combat.doAbility(GO.GetComponent<gameHandler>().player, GO.GetComponent<gameHandler>().player.abilityList[1], false);
            Debug.Log("You drink some mountain dew!!");
        } else if (Input.GetKeyDown(KeyCode.F))
        {
            GO.GetComponent<gameHandler>().combat.doAbility(GO.GetComponent<gameHandler>().player, GO.GetComponent<gameHandler>().player.abilityList[0], false);
            Debug.Log("You throw a rock!!!");
        }



        //Check for dead enemy
        if (GO.GetComponent<gameHandler>().combat.checkEnemyAlive() == false)
        {
            GO.GetComponent<gameHandler>().player.incrementEXP(GO.GetComponent<gameHandler>().combat.enemy._exp);
            GO.GetComponent<gameHandler>().combat.calculateDrops( GO.GetComponent<gameHandler>().player);
            Debug.Log("You killed the enemy!");
        }
        
        hpb.currHpSet(GO.GetComponent<gameHandler>().player.derivedStats._currHP);
        hpEnemy.currHpSet(GO.GetComponent<gameHandler>().combat.enemy.enemyStats._currentHP);

    }
}
