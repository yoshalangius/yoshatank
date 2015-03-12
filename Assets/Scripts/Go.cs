using UnityEngine;
using System.Collections;

public class Go : MonoBehaviour {
    public float speed = 1f;
    public float maxLifeTime = 0f;
    public GameObject explosionPrefab;
    private float lifeTime = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float delta = Time.deltaTime;


        lifeTime += delta;
        if (lifeTime > maxLifeTime)
        {
            Destroy(this.gameObject);
        }
        transform.Translate(Vector3.forward * speed * delta);   
	}

    void OnCollisionEnter(Collision coll)
    {
        Instantiate(explosionPrefab, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);

    }
}
