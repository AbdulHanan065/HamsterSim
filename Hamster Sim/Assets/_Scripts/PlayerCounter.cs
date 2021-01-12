using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCounter : MonoBehaviour
{


    #region Singleton
    private static PlayerCounter _Instance;
    public static PlayerCounter Instance
    {
        get
        {

            if (!_Instance) _Instance = FindObjectOfType<PlayerCounter>();

            return _Instance;
        }
    }

    private void Awake()
    {
        if (!_Instance) _Instance = this;


    }
    #endregion


    public int PlayerCount;
    // Start is called before the first frame update


    //private void OnEnable()
    //{
    //    PlayerCount++;

    //    WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].TotalPlayerCount = PlayerCount;
    //}


}
