using UnityEngine;
using System.Collections;
using UnityEngine.UI;	//てきすと関係をいじるときに必要なもの
public class GameController : MonoBehaviour
{
    public Text scoreLabel;
	[SerializeField] private GameObject winnerLabelObject;
    public void Update ()
    {
        int count = GameObject.FindGameObjectsWithTag ("Item").Length;
        scoreLabel.text = count.ToString ();
		if (count == 0) {
            // オブジェクトをアクティブにする
            winnerLabelObject.SetActive (true);
        }
    }
}
/*
Itemとしてタグづけている





*/