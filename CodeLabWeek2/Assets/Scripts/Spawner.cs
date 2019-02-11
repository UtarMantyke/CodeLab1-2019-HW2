using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn",3,2);//Call Spawn after 3 seconds and then every 2 seconds
		InvokeRepeating("SpawnSpeedDown",5,4);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn()
	{
		GameObject newPrize = Instantiate(Resources.Load<GameObject>("Prefab/Prize"));
		newPrize.transform.position = new Vector2(Random.Range(-8,8),Random.Range(-3,5));
	}

	void SpawnSpeedDown()
	{
		GameObject newSpeedDown = Instantiate(Resources.Load<GameObject>("Prefab/SpeedDownCube"));
		newSpeedDown.transform.position = new Vector2(Random.Range(-8,8),Random.Range(-3,5));
	}
}
