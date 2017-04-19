using UnityEngine;
using System.Collections;
using UnityEngine.UI;	//てきすと関係をいじるときに必要なもの
public class GameController : MonoBehaviour
{
    public Text scoreLabel;
	[SerializeField] private GameObject winnerLabelObject;

	private bool isFinished = false;

    public void Update ()
    {
        int count = GameObject.FindGameObjectsWithTag ("Item").Length;
        scoreLabel.text = count.ToString ();
		if (count == 0 && !isFinished) {
            // オブジェクトをアクティブにする
			isFinished = true;
            winnerLabelObject.SetActive (true);

        }
    }

	public bool GetisFinished(){
		return isFinished;

	}
}
/*
Itemとしてタグづけている





*/