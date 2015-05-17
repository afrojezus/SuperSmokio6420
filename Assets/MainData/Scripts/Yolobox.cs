using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Yolobox : MonoBehaviour {

	public Text MessageBox;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			MessageBox.text = "RIP in piss, dank brother. desu.";
			Color color = MessageBox.color;
			color.a -= 0.1f;
			MessageBox.color = color;
		}
	}
}
