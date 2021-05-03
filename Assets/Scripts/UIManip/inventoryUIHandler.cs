using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using sLibrary;

public class inventoryUIHandler : MonoBehaviour
{
    // THE ALMIGHTY COPY PASTE >>> GO.GetComponent<gameHandler>()
    GameObject GO;

    Image cum;
    Sprite sperm;

    // Start is called before the first frame update
    void Start()
    {
        GO = GameObject.Find("FakePlayer");
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.S))
        {
            GO.GetComponent<gameHandler>().player.inventory.AddEquipItem(GO.GetComponent<gameHandler>().combat.items.equipmentList[0], 1, true);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            GO.GetComponent<gameHandler>().player.inventory.AddEquipItem(GO.GetComponent<gameHandler>().combat.items.equipmentList[1], 1, true);
        }

        for (int i = 0; i < 24; i++)
        {
            cum = GameObject.Find("Canvas/invPanel/invSlotHandler/slot ("+ i +")/item").GetComponent<Image>();

            if (GO.GetComponent<gameHandler>().player.inventory.GetEquipItem(i) != null)
            {
                sperm = GO.GetComponent<spriteLibrary>().sprites[GO.GetComponent<gameHandler>().player.inventory.GetEquipItem(i)._icon];
                cum.sprite = sperm;
            }
        }
    }
}
