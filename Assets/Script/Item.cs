using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //[Header("コメント")]でInspector上にコメントを表示できる
    //[SerializeField]でpublicじゃなくてもInspector上に表示できる
    [Header("加算されるスコア")]
    [SerializeField]
    public int Score;

    //アイテムの皮
    SpriteRenderer Item_Coller { get; set; }

    [Header("点滅速度")]
    [SerializeField]
    float Fead_Speed;

    //色用の数値
    [SerializeField]
    float R, G, B, A;

    //点滅切り替えのスイッチ
    [SerializeField]
    bool Fead;

    private void Start()
    {
        Item_Coller = GetComponent<SpriteRenderer>();

        //R,G,BとAlpha値(透明度)を代入
        R = Item_Coller.color.r;
        G = Item_Coller.color.g;
        B = Item_Coller.color.b;
        A = Item_Coller.color.a;
    }


    //FidedUpdateは「フレーム毎」に処理されるタイプのUpdate
    //「スペックの違うPCで動かしたらバグる！」ってならないようにできるぞ！
    //ちなみにキーボード入力とかをここで処理すると
    //フレームに合わせて押さないと反応しなくなったりするので注意だ！
    private void FixedUpdate()
    {
        //点滅処理
        if(1 <= R)
        {
            Fead = true;
        }
        else if(R <=0)
        {
            Fead = false;
        }

        if(Fead == true)
        {
            R -= Fead_Speed;
            G -= Fead_Speed;
            B -= Fead_Speed;
        }
        else
        {
            R += Fead_Speed;
            G += Fead_Speed;
            B += Fead_Speed;
        }

        //色を反映
        Item_Coller.color = new Color(R,G,B,A);
    }


    //スタートは開始時、Updateは常に呼ばれる処理なのと同じで、
    //「Ontrigger」も接触関係で自動的に呼ばれる処理
    //その後ろが「Enter」なら「重なった時」に呼ばれ、
    //「Stay」なら「重なっている間」に呼ばれ、
    //「Exit」なら「重なんなくなった時」に呼ばれる。英語の意味そのまんま。
    //2Dは2Dゲームの処理だから付いてる。3Dの時は書かなくていいよー

    //(Collider2D collider)
    //重なったオブジェクトの「Collider2D」を「collider」に格納している。
    //なのでこの処理内では　collider = 重なってる奴　として扱える。
    //ちなみにこれはintやfloatのように「Collider2D」って形の変数だから、
    //Hierarchyに置いてあるようなGameObjectではなく、
    //そのGameObjectの中身のColliderを指してるので注意

    //だからif文の所で
    //「collider.gameObject.tag」で「このコライダーを持ってる、ゲームオブジェクトの、タグ」
    //って指示する必要があったんですね^^

    private void OnTriggerEnter2D(Collider2D collider)
    {
        // 物体がアイテムに接触したとき、一度だけ呼ばれる
        Debug.Log("b");

        // 接触したのがプレイヤーの場合
        if (collider.gameObject.tag == ("Player"))
        {
            //消す(この.ゲームオブジェクトを)
            Destroy(this.gameObject);   
        }

    }
}
