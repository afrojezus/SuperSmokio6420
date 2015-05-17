using UnityEngine;
using System.Collections;

public class LoadingScreen46 : MonoBehaviour{
	static LoadingScreen46 instance;
	GameObject loadingScreenImage;

	void Awake(){
		loadingScreenImage = GameObject.Find("ImageLS");
		if (instance){
			Destroy(gameObject);
			hide();
			return;
		}
		instance = this;
		instance.loadingScreenImage.SetActive(false);
		DontDestroyOnLoad(this);
	}

	void Update()
	{
		if(!Application.isLoadingLevel)
			hide();
	}

	public static void show()
	{
		if (!InstanceExists()){
			return;
		}

		instance.loadingScreenImage.SetActive(true);
	}

	public static void hide(){
		if(!InstanceExists())
		   {
			return;
		}
		instance.loadingScreenImage.SetActive(false);
	}

	static bool InstanceExists(){
		if (!instance){
			return false;
		}
		return true;
	}

}