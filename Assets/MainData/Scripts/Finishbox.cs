using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Finishbox : MonoBehaviour {

	public Text MessageBox;
	public MatteFade BlackMatte;
	public GameObject InputManager;

	public float ExitFadeOutTime = 1.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			MessageBox.text = "Yo, the map is finished, good job desu.";
			InputManager.SetActive(false);
			StartCoroutine(Exit ());
		}
	}

	IEnumerator Exit(){
		Time.timeScale = 1;
		yield return new WaitForSeconds(1.5f);

        BlackMatte.gameObject.SetActive(true);

        yield return new WaitForSeconds(1.0f);
		BlackMatte.gameObject.SetActive (true);
		LoadingScreen46.show ();
		Application.LoadLevel ("game2");
		}
}
