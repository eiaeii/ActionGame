using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

    public GameObject prefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public GameObject Spawn()
    {
        return Instantiate(prefab, transform.position, transform.rotation) as GameObject;
    }
}
