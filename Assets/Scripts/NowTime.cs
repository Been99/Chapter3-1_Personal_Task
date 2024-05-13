using System;
using UnityEngine;
using UnityEngine.UI;

public class NowTime : MonoBehaviour
{
    public Text TimeTxt;

    void Start()
    {
        GetCurrentTime();   
    }

    public void GetCurrentTime()
    {
        string nowTime = DateTime.Now.ToString("t");
        TimeTxt.text = "현재시간 : " + nowTime;
    }
}