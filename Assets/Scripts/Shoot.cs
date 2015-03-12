﻿using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    public GameObject bulletPrefab;
    private GameObject turret;
    private GameObject nozzle;
    


	// Use this for initialization
	void Start () {

      Transform[] transforms = GetComponentsInChildren<Transform>();
      foreach (Transform t in transforms)
      {
          if(t.gameObject.name == "Turret")
          {
              turret = t.gameObject;
          }
          if (t.gameObject.name == "Nozzle")
          {
              nozzle = t.gameObject;
          }
      }
	}
	
	// Update is called once per frame
	void Update () {

        Quaternion rotation = Quaternion.Euler(Vector3.up * turret.transform.eulerAngles.y);



        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bulletPrefab, nozzle.transform.position, rotation);
        }
	}
}
