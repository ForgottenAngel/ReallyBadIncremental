using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Character;

namespace statTH
{
    public class StatTextHandler : MonoBehaviour
    {
        //Creates new object in order to access variables
        characterHandler txtCH = new characterHandler();

        //Text Definitions
        //Basic Stats
        Text hptext;
        Text mptext;
        Text strtext;
        Text inttext;
        Text context;
        Text wiltext;

        //Specialized Stats
        Text critRtext;
        Text critDtext;
        Text acctext;
        Text hitRtext;
        Text avotext;
        Text dodtext;
        Text blkRtext;



        void Start()
        {
            //Assigns Each text definition to a corresponding gameobject
            //Base Stats
            hptext = GameObject.Find("Canvas/hp_txt").GetComponent<Text>();
            mptext = GameObject.Find("Canvas/mp_txt").GetComponent<Text>();

            strtext = GameObject.Find("Canvas/str_txt").GetComponent<Text>();
            inttext = GameObject.Find("Canvas/int_txt").GetComponent<Text>();
            context = GameObject.Find("Canvas/con_txt").GetComponent<Text>();
            wiltext = GameObject.Find("Canvas/wil_txt").GetComponent<Text>();

            //Specialized Stats
            critRtext = GameObject.Find("Canvas/critR_txt").GetComponent<Text>();
            critDtext = GameObject.Find("Canvas/critD_txt").GetComponent<Text>();
            acctext = GameObject.Find("Canvas/acc_txt").GetComponent<Text>();
            hitRtext = GameObject.Find("Canvas/hitR_txt").GetComponent<Text>();
            avotext = GameObject.Find("Canvas/avo_txt").GetComponent<Text>();
            dodtext = GameObject.Find("Canvas/dod_txt").GetComponent<Text>();
            blkRtext = GameObject.Find("Canvas/blkR_txt").GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            //Updates the text based on the player stats
            //Base Stats
            hptext.text = "Max Health = " + txtCH.derivedStats._maxHP.ToString();
            mptext.text = "Max Mana = " + txtCH.derivedStats._maxMP.ToString();

            strtext.text = "Strength = " + txtCH.derivedStats._totalStr.ToString();
            inttext.text = "Intelligence = " + txtCH.derivedStats._totalInt.ToString();
            context.text = "Constitution = " + txtCH.derivedStats._totalCon.ToString();
            wiltext.text = "Willpower = " + txtCH.derivedStats._totalWil.ToString();

            //Specialized Stats
            critRtext.text = "Critical Rate = " + txtCH.specialStats._criticalRate.ToString("0.##\\%");
            critDtext.text = "Critical Damage = " + txtCH.specialStats._criticalDamage.ToString("0.##\\%");
            acctext.text = "Accuracy = " + txtCH.specialStats._accuracy.ToString();
            hitRtext.text = "Hit Rate = " + txtCH.specialStats._hitRate.ToString("0.##\\%");
            avotext.text = "Avoidability = " + txtCH.specialStats._avoidability.ToString();
            dodtext.text = "Dodge Rate = " + txtCH.specialStats._dodgeRate.ToString("0.##\\%");
            blkRtext.text = "Block Rate = " + txtCH.specialStats._blockRate.ToString("0.##\\%");
        }
    }
}
