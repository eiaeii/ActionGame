using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public float speed = 3;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        Vector3 targetPos = player.transform.position + new Vector3(0, 3, -3.5f);
        transform.position = Vector3.Lerp(transform.position, targetPos, speed * Time.deltaTime);

        //Quaternion targetRotation = Quaternion.LookRotation(player.position - transform.position);
        //transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);
	}
}
