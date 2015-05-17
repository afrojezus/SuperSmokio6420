using UnityEngine;
using System.Collections;

public class mainmenu : MonoBehaviour {

	public string sceneName;
	public AudioSource audio;

	// Use this for initialization
	void Start (){
		Cursor.visible = true;
		if (Application.loadedLevelName == "mainmenu") {
						string sceneName = "game1";
				}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.F11)) {
						Application.LoadLevel ("420");
						Debug.Log ("Smoke weed everyday!");
				}
		
	}

	public void StartGame(){
		LoadingScreen46.show ();
		audio.Play ();
		Application.LoadLevel (sceneName);
		}

	public void QuitGame(){
		Application.Quit ();
		}
}
