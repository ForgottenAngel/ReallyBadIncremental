using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace sLibrary
{
    public class spriteLibrary : MonoBehaviour
    {
       public Dictionary<int, Sprite> sprites;

        // Start is called before the first frame update
        void Awake()
        {
            sprites = new Dictionary<int, Sprite>();
            sprites.Add(0, Resources.Load<Sprite>("swood"));

            sprites.Add(1, Resources.Load<Sprite>("mooce"));
        }

    }
}