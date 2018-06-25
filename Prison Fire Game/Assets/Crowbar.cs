using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crowbar : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Police")
        {
            Destroy(col.gameObject);
        }

        if (col.gameObject.name == "Enemy NPC")
        {
            Destroy(col.gameObject);
        }










    }





}
