using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameInfo : MonoBehaviour {

	private Text gInfo;

	// Use this for initialization
	void Start () {
		gInfo = gameObject.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevelName == "game1") {
						gInfo.text = "Get 69 joints and smash into the flying castle!";
						FadeOut ();
				}
		if (Application.loadedLevelName == "game2") {
			gInfo.text = "Find Snoop Doggs golden joint and escape!";
			FadeOut ();
		}
		if (Application.loadedLevelName == "game3") {
			gInfo.text = "Get high with Bowser and win against the Kushmeister 420!";
			FadeOut ();
		}
	
	}

	void FadeOut(){
		gInfo.CrossFadeAlpha (0, 2f, false);
		}
}
