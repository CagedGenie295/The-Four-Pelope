using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class music : MonoBehaviour {

    // Use this for initialization
    bool ismain = false;
	

    private void OnLevelWasLoaded()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(0))
        {
            if (!ismain)
            {
                Destroy(gameObject);
            }
        }
    }
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        ismain = true;
    }


    // Update is called once per frame
    void Update () {
		
	}
}
