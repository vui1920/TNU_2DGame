using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("速度")]
    public float speed = 3.5f;  //浮點
    [Header("跳躍")]
    public int jump = 200;      //整型
    [Header("是否在地板")]
    public bool isGroud = false;//布爾
    [Header("角色名稱")]
    public string _name = "KID";//字符串
}
