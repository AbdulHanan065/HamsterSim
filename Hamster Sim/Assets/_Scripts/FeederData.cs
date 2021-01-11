using System;
using UnityEngine;

[CreateAssetMenu(fileName = "FeederData", menuName = "ScriptableObjects/FeederDataScriptableObject", order = 1)]
public class FeederData : ScriptableObject
{

   
    public _FeederData[] Feeder_stats;



    [Serializable]
    public class _FeederData
    {
        public Sprite Icon;
        public string Name;
        public string Discription;
        public Material Mat;
        public int price;

    }

}
