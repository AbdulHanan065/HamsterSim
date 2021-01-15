using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveWorldManager : MonoBehaviour
{
  

    public GameObject _PlayerManager;




    private void Start()
    {


        for (int j = 0; j < WorldManager.Instance._WorldData.Length; j++)
        {
            WorldManager.Instance._WorldData[j].TotalPlayerCount = PlayerPrefs.GetInt("TotalPlayerCount"+j);

            for (int i = 0; i < WorldManager.Instance._WorldData[j].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType.Length; i++)
            {
                WorldManager.Instance._WorldData[j].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[i].CurrentPlayerCount = PlayerPrefs.GetInt("hamster"+i+j);
                Debug.Log("Player type :" + i + " Player Count : " + WorldManager.Instance._WorldData[j].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[i].CurrentPlayerCount);
            }


        }

        
    }


    private void OnEnable()
    {



        WorldManager.Instance._WorldData[NewUiManagerMenu.Instance.WorldNo].TotalPlayerCount = PlayerPrefs.GetInt("TotalPlayerCount" + NewUiManagerMenu.Instance.WorldNo);




        for (int i = 0; i < WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType.Length; i++)
        {
            WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[i].CurrentPlayerCount = PlayerPrefs.GetInt("hamster" + i + WorldManager.Instance.WorldIndex);
            Debug.Log("Player type :" + i + " Player Count : " + WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[i].CurrentPlayerCount);
        }




        if (PlayerPrefs.HasKey("hamster0" + WorldManager.Instance.WorldIndex))
        {

            Debug.Log("hamster0" + PlayerPrefs.GetInt("hamster0" + WorldManager.Instance.WorldIndex));

            for (int i = 0; i < PlayerPrefs.GetInt("hamster0" + WorldManager.Instance.WorldIndex); i++)
            {
                WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[0].Players[i].SetActive(true);


            }
        }
        if (PlayerPrefs.HasKey("hamster1" + WorldManager.Instance.WorldIndex))
        {

            Debug.Log("hamster1" + PlayerPrefs.GetInt("hamster1" + WorldManager.Instance.WorldIndex));

            for (int i = 0; i < PlayerPrefs.GetInt("hamster1" + WorldManager.Instance.WorldIndex); i++)
            {

                WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[1].Players[i].SetActive(true);
            }
        }
        if (PlayerPrefs.HasKey("hamster2" + WorldManager.Instance.WorldIndex))
        {

            Debug.Log("hamster2" + PlayerPrefs.GetInt("hamster2" + WorldManager.Instance.WorldIndex));

            for (int i = 0; i < PlayerPrefs.GetInt("hamster2" + WorldManager.Instance.WorldIndex); i++)
            {

                WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[2].Players[i].SetActive(true);
            }
        }
        if (PlayerPrefs.HasKey("hamster3" + WorldManager.Instance.WorldIndex))
        {

            Debug.Log("hamster3" + PlayerPrefs.GetInt("hamster3" + WorldManager.Instance.WorldIndex));

            for (int i = 0; i < PlayerPrefs.GetInt("hamster3" + WorldManager.Instance.WorldIndex); i++)
            {

                WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[3].Players[i].SetActive(true);
            }
        }
        if (PlayerPrefs.HasKey("hamster4" + WorldManager.Instance.WorldIndex))
        {

            Debug.Log("hamster4" + PlayerPrefs.GetInt("hamster4" + WorldManager.Instance.WorldIndex));

            for (int i = 0; i < PlayerPrefs.GetInt("hamster4" + WorldManager.Instance.WorldIndex); i++)
            {

                WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[4].Players[i].SetActive(true);
            }
        }
        if (PlayerPrefs.HasKey("hamster5" + WorldManager.Instance.WorldIndex))
        {

            Debug.Log("hamster5" + PlayerPrefs.GetInt("hamster5" + WorldManager.Instance.WorldIndex));

            for (int i = 0; i < PlayerPrefs.GetInt("hamster5" + WorldManager.Instance.WorldIndex); i++)
            {

                WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[5].Players[i].SetActive(true);
            }
        }
        if (PlayerPrefs.HasKey("hamster6" + WorldManager.Instance.WorldIndex))
        {

            Debug.Log("hamster6" + PlayerPrefs.GetInt("hamster6" + WorldManager.Instance.WorldIndex));

            for (int i = 0; i < PlayerPrefs.GetInt("hamster6" + WorldManager.Instance.WorldIndex); i++)
            {

                WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[6].Players[i].SetActive(true);
            }
        }
    }

    }
