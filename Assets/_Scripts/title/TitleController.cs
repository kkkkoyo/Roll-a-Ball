using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour {

	void Awake()
	{
		Screen.orientation = ScreenOrientation.LandscapeLeft;
		SoundManager.Instance.PlayBgm("loop");
	}

	public void OnClickedStart()
	{
		SoundManager.Instance.PlaySe("OK");
		SceneManager.LoadScene("stage1");
	}
		public void OnClickedBack()
	{
		SoundManager.Instance.PlaySe("OK");
		SceneManager.LoadScene("Title");
	}
}
