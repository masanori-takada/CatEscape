using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CareGenerator : MonoBehaviour
{
    public GameObject carePrefab;
    //arrowPrefabの箱を用意しておく。ここではまだ箱だけ
    //アウトレット接続により、スクリプト内の変数にオブジェクト（arrowPrefab)の実態を代入する
    //スクリプト側にコンセントの差し込み口をつくるために、変数の前にpublic修飾子をつける
    //これにより、インスペクタから変数が見えるようになり、オブジェクトをアタッチできる
    float span = 3.0f;
    float delta = 0;

    void Start()
    {
        //不要？？？？？
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        //コマ間の時間差が、Time.deltatimeに代入される
        if (this.delta > this.span)
        {
            this.delta = 0;
            //ししおどしが溜まったら元に戻るイメージ
            GameObject go = Instantiate(carePrefab) as GameObject;
            //矢印生成する
            //Instantiateメソッドは、引数に設計図を渡すと、戻り値としてインスタンスを返す
            //GameObject型の変数goを定義して、上記でできたインスタンスを代入している

            //as GameObjectは、キャストという強制的な型変換。
            //InstantiatteはObject型で返すのでそれをGameObject型にしている

            int px = Random.Range(-8, 9);
            //矢の出現するx座標の値を−６から６までの間でランダムな値とする（第一引数以上、第二引数未満）
            go.transform.position = new Vector3(px, 7, 0);
            //生成した矢印を配置する
            //変数goの出現座標を定義。Translateもそうだったが変位量や座標の定義は、３次元が基本？？
        }


    }
}
