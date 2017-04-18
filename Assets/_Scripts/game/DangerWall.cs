using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;	//シーン管理を行うためにこれをインポートする必要がある

public class DangerWall : MonoBehaviour
{
    // オブジェクトと接触した時に呼ばれるコールバック
    void OnCollisionEnter (Collision hit)
    {
        // 接触したオブジェクトのタグが"Player"の場合
        if (hit.gameObject.CompareTag ("Player")) {

            // 現在のシーン番号を取得
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;

            // 現在のシーンを再読込する
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
/*
TitleControllerのシーン呼び出し方との違いの理由
今回は同じシーンを再帰的に呼び出すことになるのでバグらないように
番号確認はBuildのところで確認できる

*/