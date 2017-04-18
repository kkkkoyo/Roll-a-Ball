using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour {


	public void OnClickedStart()
	{
		SceneManager.LoadScene("stage1");
	}
		public void OnClickedBack()
	{
		SceneManager.LoadScene("Title");
	}
}
