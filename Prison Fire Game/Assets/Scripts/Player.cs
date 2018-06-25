using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float PlayerSpeed;
    public float JumpSpeed;
    public Rigidbody2D RB;
     bool CanJump;
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector2.right * PlayerSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * PlayerSpeed);
        }
        if (Input.GetButtonDown("Jump") && CanJump == true)
        {
            transform.Translate(Vector2.up * JumpSpeed);
            CanJump = false;
        }
       



    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (RB.velocity.y == 0)
        {
            CanJump = true;
        }

    }

}
