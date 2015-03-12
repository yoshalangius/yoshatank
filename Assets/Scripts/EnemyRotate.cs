using UnityEngine;
using System.Collections;

public class EnemyRotate : BaseRotateTurret {

    public Transform player;

	// Use this for initialization
	override protected void Start () {


        
        base.Start();

	}
	
	// Update is called once per frame
	override protected void Update () {
        
        
        targetPos = player.position + Vector3.up * 0.1f;
        base.Update();


	}
}
