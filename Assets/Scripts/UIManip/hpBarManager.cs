using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using BreakInfinity;
using Character;


namespace HPBar
{
    public class hpBarManager : MonoBehaviour
    {

        //New Object Creation

        public Slider slider;

        public void maxHpSet(BigDouble health)
        {
            string maxV = health.ToString();
            float mV = float.Parse(maxV);
            slider.maxValue = mV;
            slider.value = mV;

        }

        public void currHpSet(BigDouble hp)
        {
            string currV = hp.ToString();
            float cV = float.Parse(currV);
            slider.value = cV;
        }
    }
}