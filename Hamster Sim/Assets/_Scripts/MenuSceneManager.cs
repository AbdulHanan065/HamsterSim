using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSceneManager : MonoBehaviour
{

    public GameObject MainCamera;
    public GameObject ShopCamera;
    public GameObject TopDownCamera;



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
