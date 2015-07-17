using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public float speed = 2.0f;
    public GameObject SpawnPoint;
    public GameObject spawnObject;
    public float chaosValueX = 40.0f;
    public float chaosValueY = 40.0f;
    public float spawnRate = 1.0f;
    public float minSpeed = 0.1f;
    public float maxSpeed = 0.9f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Random.Range(0, 1/spawnRate) <= 1.0f)
        {
            Vector3 spawnPos = SpawnPoint.transform.position;
            spawnPos.x -= Random.Range(-chaosValueX, chaosValueX);
            spawnPos.y -= Random.Range(-chaosValueY, chaosValueY);
            GameObject newPlane = Instantiate(spawnObject, spawnPos, Quaternion.identity) as GameObject;
            newPlane.GetComponent<PlaneMovement>().SetSpeed(Random.Range(minSpeed, maxSpeed));
        }
	}
}
