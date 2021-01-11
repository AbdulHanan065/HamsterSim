using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSceneManager : MonoBehaviour
{

    public GameObject[] PlayersSpwanPoint;
    public GameObject BowlMat;
    public GameObject HouseMat;
    public GameObject FoodMat;
    public GameObject WheelMat;


    private static MenuSceneManager _Instance;
    public static MenuSceneManager Instance
    {
        get
        {

            if (!_Instance) _Instance = FindObjectOfType<MenuSceneManager>();

            return _Instance;
        }
    }

    private void Awake()
    {
        if (!_Instance) _Instance = this;


    }
    // Start is called before the first frame update
    void Start()
    {

       
       

    }

   
}
