using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoardControl : MonoBehaviour
{
    public Vector3 currentRotation;
    float sens = .7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentRotation = GetComponent<Transform>().eulerAngles;
        if((Input.GetAxis("Horizontal") > .2) && (currentRotation.z <= 12 || currentRotation.z >= 344))
        {
            transform.Rotate(0f, 0f, sens, Space.Self);
        }
        if ((Input.GetAxis("Horizontal") < -.2) && (currentRotation.z >= 345 || currentRotation.z <= 13))
        {
            transform.Rotate(0f, 0f, -sens, Space.Self);
        }
        if ((Input.GetAxis("Vertical") > .2) && (currentRotation.x <= 12 || currentRotation.x >= 344))
        {
            transform.Rotate(sens, 0f, 0f, Space.World);
            
        }
        if ((Input.GetAxis("Vertical") < -.2) && (currentRotation.x >= 345 || currentRotation.x <= 13))
        {
            transform.Rotate(-sens, 0f, 0f, Space.World);
        }
    }
}
