using System;
using UnityEngine;

[CreateAssetMenu(fileName = "BGData", menuName = "ScriptableObjects/BGDataScriptableObject", order = 1)]
public class BGData : ScriptableObject
{

   
    public _BGData[] BG;



    [Serializable]
    public class _BGData
    {
        public Sprite Icon;
        public string Name;
        public string Discription;
        public Material Mat;
        public Color LightColor;
        public int price;
        public int Diamondprice;

    }

}
