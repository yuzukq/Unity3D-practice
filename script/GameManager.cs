using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    //staticをつけるとインスタンス単位で生成されるのではなく，アプリ単位で一つだけ生成される．
    //->インスタンスの参照をせずに直接GameControllerにの関数，変数にアクセスできるようになる．

    private int totalScore = 0;  // 衝突回数を記録する変数

    private void Awake()//Awake()はゲーム開始時にStart()より先に呼ばれる．
    {
        instance = this;
    }

    // スコアを増やす関数
    public void AddScore()
    {
        totalScore++;
        Debug.Log($"現在のスコア: {totalScore}");
    }

    // スコアを取得する関数
    public int GetScore()
    {
        return totalScore;
    }

}
