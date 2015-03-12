using UnityEngine;
using System.Collections;

public class DiePlayer : MonoBehaviour {

    public int playerHealth = 10;
    public GameObject explosionPrefab;
   


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
            playerHealth -= 5;
        }
        if(playerHealth <= 0)
        {
            Instantiate(explosionPrefab, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }

    }



}
