using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjToWorld : MonoBehaviour
{
    public string ID;

    // Start is called before the first frame update
    void Start()
    {

    

    }

    
    public void MoveObj(int MoveToworldindex)
    {

        WorldManager.Instance._WorldData[WorldManager.Instance.WorldIndex].TotalPlayerCount--;

        WorldManager.Instance._WorldData[MoveToworldindex].TotalPlayerCount++;

    }

}
