using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public float vitesseTranslation=0.2f;
    private CharacterController myController;
    // Start is called before the first frame update
    void Start()
    {
        myController=gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouvementZ = Input.GetAxis("Vertical")*Vector3.forward * vitesseTranslation * Time.deltaTime;
        Vector3 mouvementX = Input.GetAxis("Horizontal")*Vector3.right * vitesseTranslation * Time.deltaTime;
        Vector3 mouvement=transform.TransformDirection(mouvementZ + mouvementX);
        myController.Move(mouvement);
    }
}
