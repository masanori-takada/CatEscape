using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    [SerializeField]
    private int minute;
    [SerializeField]
    private float seconds;
    //　前のUpdateの時の秒数
    private float oldSeconds;
    //　タイマー表示用テキスト
    private Text timerText;

    GameObject hpGauge;

    void Start()
    {
        minute = 0;
        seconds = 5f;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<Text>();

        hpGauge = GameObject.Find("hpGauge");
    }

    void Update()
    {
        seconds -= Time.deltaTime;
        timerText.text = ((int)seconds).ToString("00");

        if (seconds > 0f && hpGauge.GetComponent<Image>().fillAmount < 0f)
        {
            timerText.text = "あなたの負け";
        }

        else if (seconds < 0f && hpGauge.GetComponent<Image>().fillAmount > 0f)
        {
            timerText.text = "あなたの勝ち";
        }

        

        //if (seconds < 0f && this.hpGauge.GetComponent<Image>().fillAmount > 0f)
        //{
        //    timerText.text = "あなたの勝ち";
        //}

        //以下は、秒から分への切り替え（今回は使用しないコード）

        //if (seconds >= 60f)
        //{
        //    minute++;
        //    seconds = seconds - 60;
        //}
        //　値が変わった時だけテキストUIを更新


        //if ((int)seconds != (int)oldSeconds)
        //{
        //    timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        //}
        //oldSeconds = seconds;


    }
}
