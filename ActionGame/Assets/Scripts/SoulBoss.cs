using UnityEngine;
using System.Collections;

public class SoulBoss : MonoBehaviour {
    private Transform player;
    private float attackDistance = 1.5f;
    public float speed = 2;
    private CharacterController cc;
    public Animator bosssController;
    private float attackTime = 3;
    private float attackTimer = 0;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag(Tags.strPlayer).transform;
        cc = GetComponent<CharacterController>();
        attackTimer = attackTime;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 targetPos = player.position;
        targetPos.y = transform.position.y;
        transform.LookAt(targetPos);
        float distance = Vector3.Distance(targetPos, transform.position);
        if (distance > attackDistance)
        {
            attackTimer = attackTime;
            bosssController.SetBool("walk", true);
            if (bosssController.GetCurrentAnimatorStateInfo(0).IsName("BossRun01"))
            {
                cc.SimpleMove(transform.forward * speed);
            }
        }
        else
        {
            bosssController.SetBool("walk", false);
            attackTimer += Time.deltaTime;
            if (attackTimer > attackTime)
            {
                attackTimer = 0;
                int num = Random.Range(0, 2);
                print(num);
                if (num == 0)
                {
                    bosssController.SetTrigger("attack1");
                }
                else
                {
                    bosssController.SetTrigger("attack2");
                }
            }    
        }
	}
}
