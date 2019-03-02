using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.ImageEffects;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{

    float rotateSpeed = 1f;
    public GameObject target;
    public float speed = 5000f;

    private float jump;

    void Start()
    {
        Cursor.visible = false;
      
    }

    void Update()
    {

        if(Input.GetKey(KeyCode.Space))
        {
            jump = jump + 10f;
        }
        if (Input.GetKey(KeyCode.C))
        {
            jump = jump - 10f;
        }
        Vector3 movement = new Vector3(CrossPlatformInputManager.GetAxisRaw("Horizontal") * Time.deltaTime * speed, jump * Time.deltaTime, CrossPlatformInputManager.GetAxisRaw("Vertical") * Time.deltaTime * speed);
        transform.Translate(movement);
        jump = 0;
        MouseLookAround();

    }
    public void MouseLookAround()
    {
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        target.transform.Rotate(0, horizontal, 0);
        float desiredAngleH = target.transform.eulerAngles.y;
        float desiredAngleV = target.transform.eulerAngles.x;
        Quaternion rotation = Quaternion.Euler(desiredAngleV, desiredAngleH, 0);

        transform.LookAt(target.transform);

    }
}
