using UnityEngine;
using System.Collections;

public class DestroyableObject : MonoBehaviour 
{
	public int currentHealth = 10;

	void Start () 
	{
	
	}
	

	void Update () 
	{
	
	}

	void OnCollisionEnter(Collision coll)
	{
		if(coll.gameObject.name == "Bullet(Clone)")
		{
			currentHealth -= 5;
		}
		if(currentHealth <= 0)
		{
			Destroy(this.gameObject);   
		}
		
	}

}
