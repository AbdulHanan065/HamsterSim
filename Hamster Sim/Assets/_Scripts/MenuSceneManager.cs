using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSceneManager : MonoBehaviour
{
    [Header("<--- Cameras --->")]
    public GameObject MainCamera;
    public GameObject ShopCamera;
    public GameObject TopDownCamera;

    [Header("<--- Lights --->")]
    public GameObject DirectionalLight;

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

        FindObjectOfType<AudioManager>().PlaySound("BG");



        //Invoke("inItWait", 1f);
    }


    void inItWait()
    {
        for (int i = 0; i < WorldManager.Instance._WorldData.Length; i++)
        {
            WorldManager.Instance._WorldData[i].World.SetActive(false);
        }

        WorldManager.Instance._WorldData[0].World.SetActive(true);
    }
   
}
