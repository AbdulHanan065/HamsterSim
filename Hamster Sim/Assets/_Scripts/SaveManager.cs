using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSaving
{
    public string sceneName; // This will be written in the json file
    
    public Vector3 serializedPosition; // This will be written in the json file
    public Quaternion serializedRotation; // This will be written too.
    public static Vector3 position; // Static fields doesnt write into json
    public static Quaternion rotation; // Static fields doesnt write into json
    public string id;
    public static bool loaded = false;
}
public class SaveManager : MonoBehaviour
{
    // Start is called before the first frame update
   
    public GameSaving gameSaving;
    public GameObject player;
    public string saveFilename;

    public string namee;
    public string uniqueId;

    private string savedSceneName;

    void Start()
    {
        if (GameSaving.loaded)
        {
            this.transform.position = GameSaving.position;
            this.transform.rotation = GameSaving.rotation;
            GameSaving.loaded = false;
        }

        uniqueId =  namee+UiMangerMenu.Instance.HamsterCount[UiMangerMenu.Instance.PlayerIndex].ToString();
    }
   

    // Update is called once per frame
    void Update()
    {

        

    }

    public void SaveData()
    {
        //References
       // Scene scene = SceneManager.GetActiveScene();
        GameSaving gameSaving = new GameSaving();
        //Scene Name
        //gameSaving.sceneName = scene.name;

        //Position 
        gameSaving.serializedPosition = this.transform.position;
        GameSaving.position = gameSaving.serializedPosition;

        //Rotation
        gameSaving.serializedRotation = this.transform.rotation;
        GameSaving.rotation = gameSaving.serializedRotation;

        gameSaving.id = uniqueId;

        string jsonData = JsonUtility.ToJson(gameSaving);
       // File.WriteAllText(Application.persistentDataPath, jsonData);
        File.WriteAllText(Application.dataPath+ "/" + saveFilename + UiMangerMenu.Instance.HamsterCount[UiMangerMenu.Instance.PlayerIndex]+ ".txt", jsonData);

        Debug.Log("saveobj.serializedPosition" + gameSaving.serializedPosition);
        Debug.Log("saveobj.serializedRotation" + gameSaving.serializedRotation);
        Debug.Log(Application.dataPath + "data saved");

    }
    public  void LoadData()
    {
        //GameSaving gameSaving = JsonUtility.FromJson<GameSaving>(File.ReadAllText(Application.persistentDataPath + "/saveload.json"));
       

        string saveString = File.ReadAllText(Application.dataPath + "/"+ saveFilename+ UiMangerMenu.Instance.HamsterCount[UiMangerMenu.Instance.PlayerIndex]+".txt");
        GameSaving saveobj = JsonUtility.FromJson<GameSaving>(saveString);


        this.transform.position = saveobj.serializedPosition;
        this.transform.rotation = saveobj.serializedRotation;

        // SceneManager.LoadScene(saveobj.sceneName);
        Debug.Log("saveobj.serializedPosition" + saveobj.serializedPosition);
        Debug.Log("saveobj.serializedRotation" + saveobj.serializedRotation);
       
        GameSaving.loaded = true;

        Debug.Log(Application.dataPath + "data loaded");
    }
}
