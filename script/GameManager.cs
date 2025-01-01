using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager instance; //GameManager型の変数instance
    //staticをつけるとインスタンス単位で生成されるのではなく，アプリ単位で一つだけ生成される．
    //->インスタンスの参照をせずに直接GameManagerにの関数，変数にアクセスできるようになる．

    private void Awake()//Awake()はゲーム開始時にStart()より先に呼ばれる．
    {
        instance = this; // このGameManagerをinstanceに格納
    }

    public void TestStatic()
    {
        Debug.Log("staticのテスト中");
    }

}
