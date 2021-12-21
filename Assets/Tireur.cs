using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tireur : MonoBehaviour
{
    public GameObject Projectile;
    public float speed=200.0f;
    public AudioClip soundShoot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")||Input.GetButtonDown("Jump"))
        {
             if (Projectile)
             {
                 GameObject newProjectile=Instantiate(Projectile, gameObject.transform.position + transform.forward ,transform.rotation )as GameObject;
                      //this est remplcée dans unity par gameobject
                //lancer un projectile
                 if(newProjectile.GetComponent<Rigidbody>()==null) 
                 {
                     newProjectile.AddComponent<Rigidbody>();
                 }
                 newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward*speed);
                 if (soundShoot)
                 {
                     AudioSource.PlayClipAtPoint(soundShoot,transform.position);
                 }
             }
        }


    }
}
