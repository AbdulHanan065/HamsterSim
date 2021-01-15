using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjToWorld : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {

    

    }

    
    public void MoveObj(int MoveToworldindex)
    {
        if (WorldManager.Instance._WorldData[MoveToworldindex].TotalPlayerCount < 10)
        {
            // minus the count from active world
            WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].TotalPlayerCount--;
            // adding new player in desired world
            WorldManager.Instance._WorldData[MoveToworldindex].TotalPlayerCount++;

            // minus player from which type is it
            WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[ClickOnObj.instacne.Type].CurrentPlayerCount--;
            // addeding player in right type in desired world
            WorldManager.Instance._WorldData[MoveToworldindex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[ClickOnObj.instacne.Type].CurrentPlayerCount++;


            PlayerPrefs.SetInt("hamster" + ClickOnObj.instacne.Type + WorldManager.Instance.WorldIndex, WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[ClickOnObj.instacne.Type].CurrentPlayerCount);
            PlayerPrefs.SetInt("hamster" + ClickOnObj.instacne.Type + MoveToworldindex, WorldManager.Instance._WorldData[MoveToworldindex].World.GetComponent<ActiveWorldManager>()._PlayerManager.GetComponent<PlayerManager>()._PlayerType[ClickOnObj.instacne.Type].CurrentPlayerCount);

            ClickOnObj.instacne.Player.SetActive(false);

            //ClickOnObj.instacne.Player = null;

        }
        else
        {
            // limit reached for this item cannot move is desired world
            NewUiManagerMenu.Instance.LimitReachedCanotMoveinDesiredPanel.SetActive(true);

        }
       
    }

}
