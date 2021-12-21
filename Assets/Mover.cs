using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

public bool translateX=true;
public bool translateY=false;
public float vitesseTranslation = 0.2f;
public bool RotationY=true;
public float vitesseRotation = 20;

  // Update is called once per frame
    void Update()
    {
        if(translateX)
        {
            gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad)*vitesseTranslation);
        }
        else
        {gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad)*vitesseTranslation);

if (RotationY)
{
    gameObject.transform.Rotate(Vector3.up * vitesseRotation);
}
        }






        
    }






    // Start is called before the first frame update
  /*  void Start()
    {
        
    }*/

  
}
