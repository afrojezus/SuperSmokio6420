using UnityEngine;
using System.Collections;

public class pausemenu : MonoBehaviour {
	public GameObject pause;

	// Use this for initialization
	void Start () {
		Cursor.visible = false;	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
						Cursor.visible = true;
						pause.SetActive (true);
						Debug.Log ("Paused");
				}
	else {
			Cursor.visible = false;
			pause.SetActive (false);
				}
		
	}

	public void StartGame(){
		Application.LoadLevel (1);
		}

	public void QuitGame(){
		Application.Quit ();
		}
}
