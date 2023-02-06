using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour {

	public static PlatformManager Instance = null;

	[SerializeField] GameObject platformPrefab;
	[SerializeField] float respawnDelay = 3.5f;

	void Awake()
	{
		if (Instance == null) 
			Instance = this;
		else if (Instance != this)
			Destroy (gameObject);
		
	}
	// Use this for initialization
	void Start () {
		Instantiate (platformPrefab, new Vector2 (157.0f, 6.0f), platformPrefab.transform.rotation);
	}

	IEnumerator SpawnPlatform(Vector2 spawnPosition)
	{
		yield return new WaitForSeconds (respawnDelay);
		Instantiate (platformPrefab, spawnPosition, platformPrefab.transform.rotation);
	}

}
