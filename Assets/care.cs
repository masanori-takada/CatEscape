using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class care : MonoBehaviour
{
    GameObject player;
    //衝突判定をするには、矢とプレイヤーの距離関係が必要であり、プレイヤーのオブジェクトを扱う必要がある
    //まずはGameObject型の箱を作る。ただしこの時点で中身は空っぽ。

    void Start()
    {
        this.player = GameObject.Find("player");
        //箱に対するオブジェクトをシーンの中から見つけてくるFindメソッド
        //playerオブジェクトを見つけてくるよ
    }

    void Update()
    {
        transform.Translate(0, -0.1f, 0);

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
            //Destroyを使って自分自身（矢オブジェクト）を破棄する
            //引数であるgameObject変数は、自分自身（矢オブジェクト）のこと
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        //p1座標からp２座標への位置ベクトル
        float d = dir.magnitude;
        //位置ベクトルの長さ
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            //FindとGetComponentはセットで覚えておく（自分以外のオブジェクトの持つスクリプト等にアクセスする方法）
            GameObject director = GameObject.Find("GameDirector");
            //GameDirectorオブジェクトをシーンから見つけてきて、変数directorに代入する
            director.GetComponent<GameDirector>().IncreaseHp();
            //GameDirectorオブジェクトのもつ、GameDirectorスクリプトを取得し、IncreaseHpメソッドを呼び出す

            Destroy(gameObject);
        }
    }
}
