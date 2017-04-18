using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {


    [SerializeField] private Transform target;    // ターゲットへの参照
//  	public Transform target;	//このような書き方でもいい
    private Vector3 offset;     // 相対座標
    void Start ()
    {
        //自分自身とtargetとの相対距離を求める
        offset = GetComponent<Transform>().position - target.position;
    }
	void Update () {
        // 自分の座標にtargetの座標を代入する     
        GetComponent<Transform>().position = target.position+offset;
	}
}

/*
[SerializeField]とは
Inspector上に任意のエディタを作成できる
ほかにも種類があるので興味があったら調べてみるとよい

カメラにくっついている。これがないとボールにカメラがついてこない

*/