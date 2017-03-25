using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public float speed;         //遊戲速度
    public float playerSpeed;   //角色移動速度
    GameObject player;          //玩家物件
    GameObject cameraObj;       //攝影機物件
    Vector3 camera2player;      //攝影機與玩家相對距離

    // 遊戲起始
    void Start()
    {
        player = GameObject.Find("player");
        cameraObj = GameObject.Find("cam"); //遊戲攝影機我們有從新命名為cam
        camera2player = cameraObj.transform.position - player.transform.position;
        speed = 0.25f;
        playerSpeed=0.1f;
    }

    // 遊戲主迴圈
    void Update()
    {
        cameraFollow();
        PlayerGo();
        Contorl();
    }

    //攝影機跟隨
    void cameraFollow()
    {
        cameraObj.transform.position = player.transform.position + camera2player;
    }

    //角色持續往前衝
    void PlayerGo()
    {
        player.transform.position += Vector3.forward * speed;
    }

    //遊戲控制
    void Contorl()
    {
        if (Input.GetKey("w"))
        {
            player.transform.position += new Vector3(0, 0, playerSpeed);
        }
        if (Input.GetKey("s"))
        {
            player.transform.position += new Vector3(0, 0, -playerSpeed);
        }
        if (Input.GetKey("a"))
        {
            player.transform.position += new Vector3(-playerSpeed, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            player.transform.position += new Vector3(playerSpeed, 0, 0);
        }
    }
}