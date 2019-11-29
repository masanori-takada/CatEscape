using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//UIを使うので忘れずに追加すること

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    //ただの箱を用意しておく

    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        //箱にシーンから見つけてきたオブジェクトを代入する
    }

    public void DecreaseHp()
        //DecreaseHpはメソッドである（voidは、関数の型）
        //startでもupdateでもなく、衝突判定の都度の関数のため、別途voidで定義している
        //後ほど矢コントローラからHPゲージの表示を呼び出すため、HPゲージの処理は、publicにしている
        //(アウトレット接続)＝（他のスクリプトと絡みがある場合は、public修飾子をつける）
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 1.1f;
        //hpGaugeオブジェクトから、Image-UI機能を引き出し、準備されているfillAmountメソッドを使用する
        if (this.hpGauge.GetComponent<Image>().fillAmount <= 0.0f)
        {
            GameObject player = GameObject.Find("player");
            Destroy(player);
        }
    }

    public void IncreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount += 0.1f;
        
    }

    void Update()
    {
        
    }
}
