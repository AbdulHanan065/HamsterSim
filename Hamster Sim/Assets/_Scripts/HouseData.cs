using System;
using UnityEngine;

[CreateAssetMenu(fileName = "HouseData", menuName = "ScriptableObjects/HouseDataScriptableObject", order = 1)]
public class HouseData : ScriptableObject
{

   
    public _HouseData[] House_stats;



    [Serializable]
    public class _HouseData
    {
        public Sprite Icon;
        public string Name;
        public string Discription;
        public Material Mat;
        public int price;
        public int Diamondprice;

    }

}
