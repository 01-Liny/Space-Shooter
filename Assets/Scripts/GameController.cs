using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
    public GameObject hazard;
    public Vector3 spawnValus;

	// Use this for initialization
	void Start () 
    {
        SpawnWaves();
	}
	
    void SpawnWaves()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnValus.x, spawnValus.x), spawnValus.y, spawnValus.z);
        Quaternion spawnRoation = Quaternion.identity;
        Instantiate(hazard, spawnPosition, spawnRoation);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
