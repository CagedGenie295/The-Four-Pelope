using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float PlayerSpeed;
    public float JumpSpeed;
	
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
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector2.up * JumpSpeed);
        }

    }


}
