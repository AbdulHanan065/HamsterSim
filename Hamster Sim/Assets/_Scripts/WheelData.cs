using System;
using UnityEngine;

[CreateAssetMenu(fileName = "WheelData", menuName = "ScriptableObjects/WheelDataScriptableObject", order = 1)]
public class WheelData : ScriptableObject
{

   
    public _WheelData[] Wheel_stats;



    [Serializable]
    public class _WheelData
    {
        public Sprite Icon;
        public string Name;
        public string Discription;
        public Material Mat;
        public int price;

    }

}
