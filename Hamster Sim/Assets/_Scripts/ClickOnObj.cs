
using Invector.vCharacterController;
using UnityEngine;

public class ClickOnObj : MonoBehaviour
{
    public static ClickOnObj instacne;


    public string ObjTag;
    public int Type;
    public float PlayerEnergy;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        instacne = this;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = this.gameObject.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider.gameObject.tag == ObjTag)
                {
                    // the object identified by hit.transform was clicked
                    Debug.Log(hit.collider.gameObject.name);

                    // check if object is player
                    if (hit.collider.gameObject.GetComponent<PlayerStats>())
                    {
                        PlayerEnergy = hit.collider.gameObject.GetComponent<PlayerStats>().Energy;
                        Type = hit.collider.gameObject.GetComponent<PlayerStats>().Type;
                        Player = hit.collider.gameObject;


                    }


                    NewUiManagerMenu.Instance.MoveToDropDownDown.SetActive(true);
                    // do whatever you want

                }
               


            }
        }

    }

    }
