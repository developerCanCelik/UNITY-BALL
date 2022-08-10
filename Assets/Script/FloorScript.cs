using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour
{
    float speed = 35.0f;

    float horizontalMouseX;
    float verticleMouseY;

    private void Update() {
           horizontalMouseX = Input.GetAxis("Mouse X") * Time.deltaTime * -speed;
        verticleMouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * speed;
        //EulerAngles ile açı değerine ulaştık.
        transform.eulerAngles += new Vector3(verticleMouseY,0,horizontalMouseX);
    }
    void verticOrHoriz(){
        horizontalMouseX = Input.GetAxis("Mouse X") * Time.deltaTime * -speed;
        verticleMouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * speed;
        //EulerAngles ile açı değerine ulaştık.
        transform.eulerAngles += new Vector3(verticleMouseY,0,horizontalMouseX);
    }
}
