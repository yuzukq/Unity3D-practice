using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform Camera;
    public float PlayerSpeed;
    public float RotationSpeed;

    //speed変数に三次元x,y,zの値の入れ物を用意
    Vector3 speed = Vector3.zero;   //キャラクタの座標を格納する変数
    Vector3 playerRote = Vector3.zero; //キャラクタの向きを格納する変数

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotation();
        Camera.transform.position = transform.position;

    }

    void Move()
    {
        speed = Vector3.zero;   //キャラクタの座標を格納する変数
        playerRote = Vector3.zero; //キャラクタの向きを格納する変数

        if (Input.GetKey(KeyCode.W))
        {
            playerRote.y = 0;   //前を向く(角度軸y=0
            MoveSet();
        }

        if (Input.GetKey(KeyCode.S))
        {
            playerRote.y = 180; //後ろ向く
            MoveSet();
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerRote.y = 90;
            MoveSet();
        }

        if (Input.GetKey(KeyCode.A))
        {
            playerRote.y = -90;
            MoveSet();
        }

        transform.Translate(speed);

    }

    void MoveSet()
    {
        speed.z = PlayerSpeed;  //transform(0, 0, PlayerSpeed)
                                //プレイやの向いてる方向= カメラの向いてる方向　＋　プレイやの向き
        transform.eulerAngles = Camera.transform.eulerAngles + playerRote;
    }

    void Rotation()
    {
        var rspeed = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
            rspeed.y = -RotationSpeed;  //transform(0, 0, PlayerSpeed)

        if (Input.GetKey(KeyCode.RightArrow))
            rspeed.y = RotationSpeed;

        Camera.transform.eulerAngles += rspeed;
    }
}
