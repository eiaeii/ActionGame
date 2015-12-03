using UnityEngine;
using System.Collections;


public class PlayerAttack : MonoBehaviour {

    private Animator playerAnimator;
    public bool isCanAttackB = false;
    // Use this for initialization
    void Start () {
        playerAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void OnRangeAttack()
    {
        playerAnimator.SetTrigger("attackRange");
    }

    public void OnNormalAttack()
    {
        if(playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("PlayerAttackA") && isCanAttackB)
        {
            playerAnimator.SetTrigger("attackB");
        }
        else
        {
            playerAnimator.SetTrigger("attackA");
        }
        
    }

    public void AttackBEvent1()
    {
        isCanAttackB = true;
    }

    public void AttackBEvent2()
    {
        isCanAttackB = false;
    }
}
