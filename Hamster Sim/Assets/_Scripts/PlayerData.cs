using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/PlayerDataScriptableObject", order = 1)]
public class PlayerData : ScriptableObject
{

   
    public _PlayerData[] stats;



    [Serializable]
    public class _PlayerData
    {
        public Sprite PlayerAvater;
        public GameObject HamsterPrefab;
        public string Name;
        public float Health;
        public float Damage;
        public float Defence;
        public float Speed;
        public string Discription;
        public int Price;
       

    }

}
