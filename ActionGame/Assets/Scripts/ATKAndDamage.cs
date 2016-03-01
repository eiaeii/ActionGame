using UnityEngine;
using System.Collections;

public class ATKAndDamage : MonoBehaviour {
    public float hp = 100;
    public float normalAttack = 50;
    public float attackDistance = 1;
    private Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	public virtual void TakeDamage(float damage)
    {
        if (hp > 0)
        {
            hp -= damage;
        }

        if (hp >0)
        {
            animator.SetTrigger("damage");
            if (this.tag == Tags.strSoulBoss)
            {
                Instantiate(Resources.Load("HitBoss"), transform.position, transform.rotation);
            }
            else if(this.tag == Tags.strSoulMonster)
            {
                Instantiate(Resources.Load("HitMonster"), transform.position, transform.rotation);
            }
        }
        else
        {
            animator.SetBool("dead", true);   
        }
    }
}
