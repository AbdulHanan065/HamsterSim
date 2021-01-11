using System;
using UnityEngine;

[CreateAssetMenu(fileName = "CageData", menuName = "ScriptableObjects/CageDataScriptableObject", order = 1)]
public class CageData : ScriptableObject
{

   
    public _CageData[] Cage_Data;



    [Serializable]
    public class _CageData
    {
        public Sprite Icon;
        public string Name;
        public string Discription;
        public Material Mat;
        public int price;

    }

}
