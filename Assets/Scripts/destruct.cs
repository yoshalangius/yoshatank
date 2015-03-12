using UnityEngine;
using System.Collections;

public class destruct : MonoBehaviour {

    private float explosionLifeTime = 0f;
    public float maxlifeTime = 3f;
   
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float delta = Time.deltaTime;

        explosionLifeTime += delta;
	if (explosionLifeTime > maxlifeTime)
    {
        Destroy(this.gameObject);
    }
	}
}
