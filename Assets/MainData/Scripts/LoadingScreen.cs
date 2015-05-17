using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour {

	public string levelToLoad;
	public RawImage background;
	public Text text;
	public RawImage progressBar;

	private int loadProgress = 0;

	// Use this for initialization
	void Start () {
		background.enabled = false;
		text.enabled = false;
		progressBar.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void StartGame(){
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
		}

	IEnumerator DisplayLoadingScreen(string level){
		background.enabled = true;
		text.enabled = true;
		progressBar.enabled = true;

		progressBar.transform.localScale = new Vector3 (loadProgress, progressBar.transform.localScale.y, progressBar.transform.localScale.z);

		text.text = "Loading " + loadProgress + "%";

		AsyncOperation async = Application.LoadLevelAsync (level);
		while (!async.isDone) {
						loadProgress = (int)(async.progress * 100);
						text.text = "Loading " + loadProgress + "%";
						progressBar.transform.localScale = new Vector3 (async.progress, progressBar.transform.localScale.y, progressBar.transform.localScale.z);

				}

		yield return null;
	}
}
