using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using EffectEnumTables;

namespace Effects
{
    // Readonly Structs to hold large amounts of data.
    public readonly struct statBoost
    {
        public float hpBoost { get; }
        public float mpBoost { get; }
        public float strBoost { get; }
        public float intBoost { get; }
        public float conBoost { get; }
        public float wilBoost { get; }

        // Constructor.
        public statBoost(float hpB, float mpB, float strB, float intB, float conB, float wilB)
        {
            hpBoost = hpB;
            mpBoost = mpB;
            strBoost = strB;
            intBoost = intB;
            conBoost = conB;
            wilBoost = wilB;
        }
    }

    public readonly struct adBoost
    {
        public float pAtkBoost { get; }
        public float mAtkBoost { get; }
        public float pDefBoost { get; }
        public float mDefBoost { get; }
        public float pDmgBoost { get; }
        public float mDmgBoost { get; }


        // Constructor.
        public adBoost(float pAtkB, float mAtkB, float pDefB, float mDefB, float pDmgB, float mDmgB)
        {
            pAtkBoost = pAtkB;
            mAtkBoost = mAtkB;
            pDefBoost = pDefB;
            mDefBoost = mDefB;
            pDmgBoost = pDmgB;
            mDmgBoost = mDmgB;
        }
    }

    public readonly struct effect
    {
        public int id { get; }
        public string name { get; }
        public string desc { get; }

        public EffectType type { get; }
        public bool isMultiplicative { get; }

        public statBoost statGain { get; }
        public adBoost adGain { get; }

        // Constructor.
        public effect(int eID, string n, string d, EffectType t, bool isMulti, statBoost sb, adBoost adb)
        {
            id = eID;
            name = n;
            desc = d;

            type = t;
            isMultiplicative = isMulti;

            statGain = sb;
            adGain = adb;
        }

    }

    public class effectCollection
    {
        public readonly Dictionary<int, effect> effectList = new Dictionary<int, effect>();

        // Constructor.
        public effectCollection()
        {
            // Temporary lists for holding the partial structs.
            List<string> effDesc = new List<string>();
            List<statBoost> sB = new List<statBoost>();
            List<adBoost> adB = new List<adBoost>();

            // Effect Definitions.

            // #0000: Power Surge (S) (Buff)
            // Provides >> +10% Max HP | +10% Max MP | +5% STR | +5% INT | +5% CON | +5% WIL
            //          >> +10% P.Atk | + 10% M.Atk | +10% P.Def | +10% M.Def | +5% P.Dmg | +5% M.Dmg
            effDesc.Add("You feel a small yet sudden surge of power.");
            sB.Add(new statBoost(0.1f, 0.1f, 0.05f, 0.05f, 0.05f, 0.05f));
            adB.Add(new adBoost(0.1f, 0.1f, 0.1f, 0.1f, 0.05f, 0.05f));
            effectList.Add(0, new effect(0, "Power Surge (S)", effDesc[0], EffectType.Buff, false, sB[0], adB[0]));

            // #0001: Demonic Fury (Buff)
            // Provides >> x1.2 STR | x1.2 INT | x1.2 CON | +5% WIL
            //          >> x1.2 P.Atk | x1.2 M.Atk | x1.1 P.Dmg | x1.1 M.Dmg
            effDesc.Add("You are consumed by the fury of a demon.");
            sB.Add(new statBoost(1f, 1f, 1.2f, 1.2f, 1.2f, 1.2f));
            adB.Add(new adBoost(1.2f, 1.2f, 1f, 1f, 1.1f, 1.1f));
            effectList.Add(1, new effect(1, "Demonic Fury", effDesc[1], EffectType.Buff, true, sB[1], adB[1]));

            // #0002: Armor Crash (Debuff)
            // Provides >> -20% P.Def | -20% M.Def
            effDesc.Add("Your armor feels like it's made of paper.");
            sB.Add(new statBoost(0f, 0f, 0f, 0f, 0f, 0f));
            adB.Add(new adBoost(0f, 0f, 0.2f, 0.2f, 0f, 0f));
            effectList.Add(2, new effect(2, "Armor Crash", effDesc[2], EffectType.Debuff, false, sB[2], adB[2]));

            // #0003: Weakened (Debuff)
            // Provides >> x0.9 Max HP | x0.9 Max MP | x0.9 STR | x0.9 INT | x0.9 CON | x0.9 WIL
            //          >> x0.9 P.Atk | x0.9 M.Atk | x0.9 P.Def | x0.9 M.Def | x0.9 P.Dmg | x0.9 M.Dmg
            effDesc.Add("You feel your power slowly slipping away.");
            sB.Add(new statBoost(0.9f, 0.9f, 0.9f, 0.9f, 0.9f, 0.9f));
            adB.Add(new adBoost(0.9f, 0.9f, 0.9f, 0.9f, 0.9f, 0.9f));
            effectList.Add(3, new effect(3, "Weakened", effDesc[3], EffectType.Debuff, true, sB[3], adB[3]));
        }
    }
}