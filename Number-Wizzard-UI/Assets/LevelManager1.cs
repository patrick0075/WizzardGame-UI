using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager1 : MonoBehaviour {
	public void LoadLevel (string name){
		Application.LoadLevel(name);
	}
	public void QuitLevel(string name){
		Debug.Log("Level quit");
		Application.Quit();
	}
}
