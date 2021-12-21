using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{ public int scoreAmount =10;
public GameObject explosionPreab;
	public float timeAmount=0.0f;
	private void OnCollisionEnter(Collision collission)
	{
		
		if (GameManager.gm)
		{
			if(GameManager.gm.gameIsOver) { return;}

			if (collission.gameObject.tag=="Projectile") 
			{

                if(explosionPreab)
                {
                    Instantiate(explosionPreab, transform.position,transform.rotation);
                }
				if(GameManager.gm)
				{
					GameManager.gm.targetHit(scoreAmount,timeAmount);
				}
			}
			Destroy(gameObject);
		}
	}
}