using UnityEngine;
using System.Collections;

public class PlayerRotate : MonoBehaviour {

    private bool isRatate = false;
    public float rotateSpeed = 1000;

	// Use this for initialization
	void Start () {
        isRatate = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (isRatate)
        {
            if (Input.GetMouseButton(0))
            {
                float y = 0;

                y = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
                if (isRatate)
                {
                    gameObject.transform.Rotate(new Vector3(0, -y, 0));

                }

            }
        }
	}

    void OnMouseDown()
    {
        isRatate = true;
    }

    void OnMouseUp()
    {
        isRatate = false;
    }
}
