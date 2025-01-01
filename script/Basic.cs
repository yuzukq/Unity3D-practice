using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : MonoBehaviour //クラスは設計図．ヒエラルキ上でゲームオブジェクトにアタッチすることでインスタンス化したいた．
{
    //public int[] array; // publicの宣言でインスペクタから値，オブジェクトを設定できる．
    //public int testvar;

    //public List<int> testList; //listは配列のように扱えるが再代入ができる．
    //利用例：弾丸とかゲーム中に生成されたものを管理するときに使う．

    int hp = 100; //修飾をつけないと自動でprivateになる．このクラスの中でしか使えない．
    //private int hp2 = 100; //privateの宣言でインスペクタから値，オブジェクトを設定できない

    //[SerializeField]
    //private int hp3 = 100; //SerializeFieldの宣言でインスペクタから値，オブジェクトを設定できる．
    public int atk; //インスペクタで設定できるインスタンス変数

    void Start()
    {
        //Debug.Log("配列のサイズは" + array.Length);   変数.Lengthで配列のサイズを取得できる．

        //for (int i = 0; i < array.Length; i++) //利用例：敵モブの生成．数がわかってるときはfor文，わからないときはwhile文
        //{
        //    Debug.Log(array[i]);
        //}

        //testList[0] = 10; // リストの0番目に10を代入できる．
        //testList.Add(100); // リストの末尾に要素を追加できる．

        //testList.Clear(); // リストの要素を全て削除できる．
        //testList.RemoveAt(0); // リストの0番目の要素を削除できる．  

        //foreach (int no in testList)//インクリメントとかしなくてもリストに入ってる要素分回せる．
        //{
        //    Debug.Log("リストの中身は" + no);
        //}

        Debug.Log(name + "の現在の敵体力: " + hp);
        Damage(atk);

        //GameManager.instance.TestStatic(); //クラス名.変数名.呼びたい関数名();

    }

    void Damage(int attackDamage)
    {
        hp -= attackDamage;
        Debug.Log(name + "攻撃実行");
        Debug.Log(name + "攻撃後の敵HP" + hp);

        if (HpCheck())
        {
            Debug.Log("瀕死");
        }
        else
        {
            Debug.Log("元気");
        }
    }

    bool HpCheck()
    {
        if (hp <= 30)
            return true;

        else
            return false;
    }


    void Update()
    {

    }
}
