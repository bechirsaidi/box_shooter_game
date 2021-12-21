using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLooker : MonoBehaviour
{
   private float horizontalSpeed = 2.0f;
   private float verticalSpeed = 2.0f;

void Start()
{
   CursorLock(true);
}

    void Update()
    {
        // Get the mouse delta. This is not in the range -1...1
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(v, h, 0);



        //appuer sur escape
        if(Input.GetButtonDown("Cancel"))
        CursorLock(false);

        //click
        if(Input.GetButtonDown("Fire1"))   //project Settings //fire1 //key or mouse button
        CursorLock(false);

    }



    private void CursorLock(bool islocked)
    {
if(islocked){
    Cursor.visible=false;
    Cursor.lockState=CursorLockMode.Locked;
}
else{
    Cursor.visible=true;
    Cursor.lockState=CursorLockMode.None;
}
    }
}
