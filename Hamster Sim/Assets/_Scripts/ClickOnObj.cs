
using Invector.vCharacterController;
using UnityEngine;

public class ClickOnObj : MonoBehaviour
{
    public string ObjTag;
   

    // Start is called before the first frame update
    void Start()
    {
        
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

                    NewUiManagerMenu.Instance.MoveToDropDownDown.SetActive(true);
                    // do whatever you want

                }
               


            }
        }

    }

    }
