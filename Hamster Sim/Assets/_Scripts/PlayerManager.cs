using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Singleton
    private static PlayerManager _Instance;
    public static PlayerManager Instance
    {
        get
        {

            if (!_Instance) _Instance = FindObjectOfType<PlayerManager>();

            return _Instance;
        }
    }

    private void Awake()
    {
        if (!_Instance) _Instance = this;


    }
    #endregion

    public PlayerTypes[] _PlayerType;



    [Serializable]
    public class PlayerTypes {

        public GameObject[] Players;
        public int CurrentPlayerCount;
    }


}
