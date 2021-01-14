using System;
using UnityEngine;

[CreateAssetMenu(fileName = "BowlData", menuName = "ScriptableObjects/BowlDataScriptableObject", order = 1)]
public class BowlData : ScriptableObject
{

   
    public _BowlData[] Bowl_stats;



    [Serializable]
    public class _BowlData
    {
        public Sprite Icon;
        public string Name;
        public string Discription;
        public Material _Mat;
        public int price;
        public int Diamondprice;

    }

}
