using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
class AutoSave
{
	static AutoSave()
	{
		EditorApplication.update += Save;
	}
	
	static double nextSave = 0.0;
	static double interval = 10.0;
	
	static void Save()
	{
		if (EditorApplication.timeSinceStartup >= nextSave && !EditorApplication.isPlayingOrWillChangePlaymode && !EditorApplication.isPlaying && EditorApplication.currentScene != "") {
			nextSave = EditorApplication.timeSinceStartup + interval;
			if (System.IO.File.Exists(EditorApplication.currentScene+"-2"))
				FileUtil.ReplaceFile(EditorApplication.currentScene+"-2",EditorApplication.currentScene+"-3");
			if (System.IO.File.Exists(EditorApplication.currentScene+"-1"))
				FileUtil.ReplaceFile(EditorApplication.currentScene+"-1",EditorApplication.currentScene+"-2");
			FileUtil.ReplaceFile(EditorApplication.currentScene,EditorApplication.currentScene+"-1");
			EditorApplication.SaveScene(EditorApplication.currentScene);
			EditorApplication.SaveAssets();
			//Debug.Log("Auto-saved "+System.DateTime.Now);
		}
	}
}