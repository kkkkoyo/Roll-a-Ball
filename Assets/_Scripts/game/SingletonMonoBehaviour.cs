using System;
using UnityEngine;

public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                Type t = typeof(T);

                instance = (T)FindObjectOfType(t);
                if (instance == null)
                {
                    Debug.LogError(t + " をアタッチしているGameObjectはありません");
                }
            }

            return instance;
        }
    }

    virtual protected void Awake ()
    {
        // 他のGameObjectにアタッチされているか調べる.
        // アタッチされている場合は破棄する.
        if (this != Instance)
        {
            Destroy(this);
            //Destroy(this.gameObject);
            Debug.LogError(
                typeof(T) +
                " は既に他のGameObjectにアタッチされているため、コンポーネントを破棄しました." +
                " アタッチされているGameObjectは " + Instance.gameObject.name + " です.");
            return;
        }

        // なんとかManager的なSceneを跨いでこのGameObjectを有効にしたい場合は
        // ↓コメントアウト外してください.
        //DontDestroyOnLoad(this.gameObject);
    }

}

/*
シーンをまたいで音楽を流すために必要なスクリプト


Unityはシーンをまたぐと,前回のシーンの値や情報を全て破棄してしまう.
つまりシーンをまたぐ度に「音楽が最初から再生されてしまう」「優者が稼いだ経験値がリセットされてしまう」
といった欠点が存在する.

これを解決するためにSingletonという技術を使う
詳しくは割愛するが簡単に説明すると,次のシーンに前回のシーンの情報を引き継げるものであると考えてもらえればよい

よって,このスクリプトはすべての意味を理解することは困難なので,今はそんな技術もあるんだなーと理解してもらえればよい

*/
