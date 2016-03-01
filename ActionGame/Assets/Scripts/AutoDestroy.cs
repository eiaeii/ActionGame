using UnityEngine;
using System.Collections;

public class AutoDestroy : MonoBehaviour {
    public float existTime = 1.0f;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, existTime);
	}
}
