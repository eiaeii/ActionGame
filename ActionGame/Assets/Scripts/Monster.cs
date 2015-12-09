using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {

    private Transform player;
    private CharacterController cc;
    private Animator monsterConroller;
    public float attackDistance = 1;
    public float speed = 3;
    public float attackTime = 2;
    public float attackTimer = 0;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag(Tags.strPlayer).transform;
        cc = GetComponent<CharacterController>();
        monsterConroller = GetComponent<Animator>();
        attackTimer = attackTime;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 targetPos = player.position;
        targetPos.y = transform.position.y;
        transform.LookAt(targetPos);
        float distance = Vector3.Distance(transform.position, targetPos);
        if (distance > attackDistance)
        {
            attackTimer = attackTime;
            monsterConroller.SetBool("run", true);
            if (monsterConroller.GetCurrentAnimatorStateInfo(0).IsName("MonRun"))
            {
                cc.SimpleMove(transform.forward * speed);
            }
            
        }
        else
        {
            monsterConroller.SetBool("run", false);
            attackTimer += Time.deltaTime;
            if (attackTimer > attackTime)
            {
                attackTimer = 0;
                monsterConroller.SetTrigger("attack");
            }
        }
	}
}
