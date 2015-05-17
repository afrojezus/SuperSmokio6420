using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;
using AlpacaSound;
using System.Collections;

public class IngameGFXkeys : MonoBehaviour {

	private CameraMotionBlur motionblur;
	private BloomOptimized bloom;
	private DepthOfField dof;
	private RetroPixel rmode;
	public AudioSource music;

	private Camera maincam;

	public Text MessageBox;

	public BoxCollider yolobox;

	float timer = 0;
	
	// Use this for initialization
	void Start () {
		motionblur = gameObject.GetComponent<CameraMotionBlur> ();
		bloom = gameObject.GetComponent<BloomOptimized> ();
		dof = gameObject.GetComponent<DepthOfField> ();
		rmode = gameObject.GetComponent<RetroPixel> ();
		maincam = gameObject.GetComponent<Camera> ();
		Debug.Log ("Ingame performance tweaks activated!");
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetButton ("F9")) {
			ColorVisible();
			MotionBlur();
			Debug.Log ("Motion blur toggled.");
			MessageBox.text = "Motion Blur is on";
			ColorFade ();
			if(motionblur.enabled == false){
				MessageBox.text = "Motion Blur is off";
				ColorFade ();
			}
				}
		if (Input.GetButton ("F10")) {
			ColorVisible();
			Bloom();
			Debug.Log ("Bloom toggled.");
			MessageBox.text = "Bloom is on";
			ColorFade ();
			if(bloom.enabled == false){
				MessageBox.text = "Bloom is off";
				ColorFade ();
			}
		}
		if (Input.GetButton ("F8")) {
			ColorVisible();
			AndroidTVMode();
			Debug.Log ("Graphics quality changed.");
			MessageBox.text = "Android mode";
			ColorFade ();
		}
		if (Input.GetButton ("F7")) {
			ColorVisible();
			RenderDistanceShort();
			Debug.Log ("Shorter it is!");
			MessageBox.text = "Short distance mode";
			ColorFade ();
			if(bloom.enabled == false){
				MessageBox.text = "Short distance on";
				ColorFade ();
			}
		}
		if (Input.GetButton ("F5")) {
			ColorVisible();
			Reset ();
			Debug.Log ("Do it all over again.");
			MessageBox.text = "Resetting...";
			ColorFade ();
		}

		if (Input.GetButton ("F6")) {
			ColorVisible();
			Retro ();
			Debug.Log ("Secret unlocked!");
			MessageBox.text = "WELCOME TO 1996";
			ColorFade ();
		}
	}

	void MotionBlur(){
		motionblur.enabled = !motionblur.enabled;
		}

	void Bloom(){
		bloom.enabled = !bloom.enabled;
		dof.enabled = !dof.enabled;
	}

	void RenderDistanceShort(){
		maincam.farClipPlane = 50F;
		}
	void AndroidTVMode(){
				QualitySettings.SetQualityLevel (1);
		}
	void Reset(){
		Application.LoadLevel (Application.loadedLevel);
		}

	void Retro(){
		bloom.enabled = false;
		motionblur.enabled = false;
		dof.enabled = false;
		maincam.farClipPlane = 50F;
		QualitySettings.SetQualityLevel (1);
		QualitySettings.antiAliasing = 0;
		QualitySettings.shadowDistance = 0;
		rmode.enabled = true;
		music.pitch = 0.64F;
		}

	void ColorFade(){
		}

	void ColorVisible(){
		
	}
}
