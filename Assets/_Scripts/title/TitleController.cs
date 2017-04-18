using System.Collections;
using System.Collections.Generic;	//これは最新版だとついてくる　さまざまな用途（List作成など）で用いるのであると便利
using UnityEngine;
using UnityEngine.SceneManagement;	//シーン管理を行うためにこれをインポートする必要がある

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



/*
http://ninagreen.hatenablog.com/entry/2016/01/13/033413


using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;// ←new!

public class GameController : MonoBehaviour {

   public void toMainScene()
   {
       SceneManager.LoadScene(“Main”);// ←new!
      //Application.LoadLevel (“Main”);//ふるいやつ
   }

}


*/
