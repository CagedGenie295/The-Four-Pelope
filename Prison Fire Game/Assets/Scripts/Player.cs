using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float PlayerSpeed;
	public Rigidbody2D RB;
    public float JumpSpeed;
    bool CanJump = true;
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyDown("d"))
        {
            RB.AddForce(Vector2.right * Input.GetAxis("Horizontal") * PlayerSpeed);
        }
        if (Input.GetButtonDown("Jump") && CanJump == true)
        {
            RB.AddForce(Vector2.up * JumpSpeed);
            CanJump = false;
        }
	}


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (RB.velocity.y == 0)
        {
            CanJump = true;
        }
    }

}
