using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;	//シーン管理を行うためにこれをインポートする必要がある

public class DangerWall : MonoBehaviour
{
    [SerializeField] private GameController gamecontroller;
    private bool isFinished = false;
    // オブジェクトと接触した時に呼ばれるコールバック
    void OnCollisionEnter (Collision hit)
    {
        if(gamecontroller.GetisFinished()){
            return ;
        }
        // 接触したオブジェクトのタグが"Player"の場合
        if (hit.gameObject.CompareTag ("Player")) {

            SoundManager.Instance.PlaySe("error");
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