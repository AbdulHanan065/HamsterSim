using System;
using UnityEngine;

[CreateAssetMenu(fileName = "FoodData", menuName = "ScriptableObjects/FoodDataScriptableObject", order = 1)]
public class FoodData : ScriptableObject
{

   
    public _FoodData[] Food_stats;



    [Serializable]
    public class _FoodData
    {
        public Sprite Icon;
        public string Name;
        public string Discription;
        public Material Mat;
        public int price;

    }

}
