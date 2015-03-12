using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {
    private float reloadTime;
    public float timeToReload;
    public GameObject bulletPrefab;
    private Transform turret;
    private Transform nozzle;
    public float range;
	// Use this for initialization
	void Start () {
        reloadTime = 0;
        Transform[] transforms = gameObject.GetComponentsInChildren<Transform>();
        foreach (Transform t in transforms)
        {
            if (t.gameObject.name == "Turret")
            {
                turret = t;
            }
            if (t.gameObject.name == "nozzle")
            {
                nozzle = t;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        reloadTime += Time.deltaTime;
        if(reloadTime >= timeToReload)
        {

            checkPlayer();

            


        }
	}

    private void checkPlayer()
    {
        Ray myRay = new Ray();
        myRay.origin = nozzle.position;
        myRay.direction = nozzle.forward;

        RaycastHit hitInfo;


       if(Physics.Raycast(myRay, out hitInfo, range))
       {
           string hitObjectName = hitInfo.collider.gameObject.name;
           if (hitObjectName == "Tank")
           {
               Instantiate(bulletPrefab, nozzle.transform.position, nozzle.rotation);
               reloadTime = 0;
           }



       }




    }

}
