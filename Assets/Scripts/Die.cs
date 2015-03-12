using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {

    public int currentHealth = 10;

   


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


    

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
