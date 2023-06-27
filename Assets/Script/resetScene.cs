using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetScene : MonoBehaviour {

	public string SceneName;

	// Use this for initialization
	void Start () {
		
	}

    public void RestarScene() 
    {
		SceneManager.LoadScene(SceneName);
    }
	
	// Update is called once per frame
	void Update () {

       
		
	}



}
