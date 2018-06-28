using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : MonoBehaviour {
    public Rigidbody2D RB;
    public float PlayerSpeed;
    public float JumpSpeed;
    bool CanJump = true;
    public Animator Anim;
    // Use this for initialization
    void Update () {
        if (Input.GetAxis("Horizontal") == 0)
        {
            Anim.Play("Idle");
        }
        if (Input.GetAxis("Horizontal") <0)
        {
           // gameObject.GetComponent<SpriteRenderer>().
            
            gameObject.transform.localScale = new Vector2(-2.675839f, gameObject.transform.localScale.y) ;
            Anim.Play("MoveLeft");
        }
        if (Input.GetAxis("Horizontal") >0)
        {
            gameObject.transform.localScale = new Vector2(2.675839f, gameObject.transform.localScale.y);
            Anim.Play("MoveLeft");
        }

        RB.AddForce(Vector2.right * Input.GetAxis("Horizontal") * PlayerSpeed);
        if (Input.GetButtonDown("Jump") && CanJump == true)
        {
            RB.AddForce(Vector2.up * JumpSpeed);
            CanJump = false;
        }
    }
	
	void OnCollisionStay2D (Collision2D collision)
    { 
		if(RB.velocity.y == 0)
        {
            CanJump = true;
        }

	}
}
