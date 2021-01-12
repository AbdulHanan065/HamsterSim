using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{

    #region Singleton
    private static WorldManager _Instance;
    public static WorldManager Instance
    {
        get
        {

            if (!_Instance) _Instance = FindObjectOfType<WorldManager>();

            return _Instance;
        }
    }

    private void Awake()
    {
        if (!_Instance) _Instance = this;


    }
    #endregion

    public WorldData[] _WorldData;
    public int WorldIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   [Serializable]
    public class WorldData
    {
        public int WorldNo;
        public GameObject World;
        public int TotalPlayerCount;
    }

}
