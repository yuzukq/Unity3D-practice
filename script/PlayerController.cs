using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform Camera;
    public float PlayerSpeed;
    public float RotationSpeed;
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
        //speed変数に三次元x,y,zの値の入れ物を用意
        var speed = Vector3.zero;   //キャラクタの座標を格納する変数
        var playerRote = Vector3.zero; //キャラクタの向きを格納する変数

        if (Input.GetKey(KeyCode.W))
        {
            speed.z = PlayerSpeed;  //transform(0, 0, PlayerSpeed)
            playerRote.y = 0;   //前を向く(角度軸y=0)
        }

        if (Input.GetKey(KeyCode.S))
        {
            speed.z = PlayerSpeed;
            playerRote.y = 180; //後ろ向く
        }

        if (Input.GetKey(KeyCode.D))
        {
            speed.z = PlayerSpeed;
            playerRote.y = 90;
        }

        if (Input.GetKey(KeyCode.A))
        {
            speed.z = PlayerSpeed;
            playerRote.y = -90;
        }
        //プレイやの向いてる方向= カメラの向いてる方向　＋　プレイやの向き
        transform.eulerAngles = Camera.transform.eulerAngles + playerRote;
        transform.Translate(speed);

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
