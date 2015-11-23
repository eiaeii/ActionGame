using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    public float speed = 4;
    private CharacterController cc;

    public Animator playerAnimator;

    // Use this for initialization
    void Start () {
        cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
       
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if (JoystackControl.horizontal != 0 || JoystackControl.vertical != 0)
        {
            h = JoystackControl.horizontal;
            v = JoystackControl.vertical;
        }
        if (Mathf.Abs(h) > 0.1 || Mathf.Abs(v) > 0.1)
        {
            playerAnimator.SetBool("run", true);
            if (playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("PlayerRun"))
            {
                Vector3 targetDir = new Vector3(h, 0, v);
                transform.LookAt(transform.position + targetDir);
                cc.transform.position = transform.position + new Vector3(h, 0, v) * Time.deltaTime * speed;
            }
        }
        else
        {
            playerAnimator.SetBool("run", false);
        }
    }
}
