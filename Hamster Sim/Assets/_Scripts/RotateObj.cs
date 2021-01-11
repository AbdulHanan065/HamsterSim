
using UnityEngine;

public class RotateObj : MonoBehaviour
{
    private Touch touch;
    private Quaternion RotationY;
    public float rotateSpeedModifier = 1.2f;
    RaycastHit hit;
    public LayerMask ObjLayer;
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, ObjLayer))
        {
            Transform objectHit = hit.transform;

            // Do something with the object that was hit by the raycast.
            Debug.Log(hit.collider.name);
            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Moved)
                {
                    RotationY = Quaternion.Euler(0f, -touch.deltaPosition.x * rotateSpeedModifier, 0f);

                    transform.rotation = RotationY * transform.rotation;
                }

            }
        }


    }
    

}
