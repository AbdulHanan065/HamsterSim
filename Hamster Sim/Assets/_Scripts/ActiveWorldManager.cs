using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveWorldManager : MonoBehaviour
{
    #region Singleton
    private static ActiveWorldManager _Instance;
    public static ActiveWorldManager Instance
    {
        get
        {

            if (!_Instance) _Instance = FindObjectOfType<ActiveWorldManager>();

            return _Instance;
        }
    }

    private void Awake()
    {
        if (!_Instance) _Instance = this;


    }
    #endregion


    public GameObject _PlayerManager;

   

    private void OnEnable()
    {

       

        WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].TotalPlayerCount = PlayerPrefs.GetInt("TotalPlayerCount");

        for (int i = 0; i < WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType.Length; i++)
        {
            WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[i].CurrentPlayerCount = PlayerPrefs.GetInt("hamster"+i+WorldManager.Instance.WorldIndex);
            Debug.Log("Player type :" + i + " Player Count : " + WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[i].CurrentPlayerCount);
        }




        if (PlayerPrefs.HasKey("hamster0"+WorldManager.Instance.WorldIndex))
        {

            Debug.Log("hamster0" + PlayerPrefs.GetInt("hamster0"+WorldManager.Instance.WorldIndex));

            for (int i = 0; i < PlayerPrefs.GetInt("hamster0"+WorldManager.Instance.WorldIndex); i++)
            {
                WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[0].Players[i].SetActive(true);


            }
        }
        if (PlayerPrefs.HasKey("hamster1"+WorldManager.Instance.WorldIndex))
        {

            Debug.Log("hamster1" + PlayerPrefs.GetInt("hamster1"+WorldManager.Instance.WorldIndex));

            for (int i = 0; i < PlayerPrefs.GetInt("hamster1"+WorldManager.Instance.WorldIndex); i++)
            {

                WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[1].Players[i].SetActive(true);
            }
        }
        if (PlayerPrefs.HasKey("hamster2"))
        {

            Debug.Log("hamster2" + PlayerPrefs.GetInt("hamster2"));

            for (int i = 0; i < PlayerPrefs.GetInt("hamster2"); i++)
            {

                PlayerManager.Instance._PlayerType[2].Players[i].SetActive(true);
            }
        }
        if (PlayerPrefs.HasKey("hamster3"))
        {

            Debug.Log("hamster3" + PlayerPrefs.GetInt("hamster3"));

            for (int i = 0; i < PlayerPrefs.GetInt("hamster3"); i++)
            {

                PlayerManager.Instance._PlayerType[3].Players[i].SetActive(true);
            }
        }
        if (PlayerPrefs.HasKey("hamster4"))
        {

            Debug.Log("hamster4" + PlayerPrefs.GetInt("hamster4"));

            for (int i = 0; i < PlayerPrefs.GetInt("hamster4"); i++)
            {

                PlayerManager.Instance._PlayerType[4].Players[i].SetActive(true);
            }
        }
        if (PlayerPrefs.HasKey("hamster5"))
        {

            Debug.Log("hamster5" + PlayerPrefs.GetInt("hamster5"));

            for (int i = 0; i < PlayerPrefs.GetInt("hamster5"); i++)
            {

                PlayerManager.Instance._PlayerType[5].Players[i].SetActive(true);
            }
        }
        if (PlayerPrefs.HasKey("hamster6"))
        {

            Debug.Log("hamster6" + PlayerPrefs.GetInt("hamster6"));

            for (int i = 0; i < PlayerPrefs.GetInt("hamster6"); i++)
            {

                PlayerManager.Instance._PlayerType[6].Players[i].SetActive(true);
            }
        }

    }


}
