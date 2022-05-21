using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //[Header("コメント")]でInspector上にコメントを表示できる
    //[SerializeField]でpublicじゃなくてもInspector上に表示できる

    [SerializeField]
    //移動ステ
    private float speed = 0.01f;

    [Header("Director系はアタッチしなくて大丈夫だよ")]
    [SerializeField]
    GameObject Director;

    [SerializeField]
    Game_Director G_Director;

    [Header("獲得したスコア")]
    [SerializeField]
    int Score;

    Rigidbody2D rb;
    float Horizontal,Vertical;

    //シーンが読み込まれた時に1周だけ処理
    void Start()
    {
        //(↓の文法)種類.見つける("名前");
        //GameObject.Find("○○");
        //上で作ったDirectorに、シーン上にある"Director"を見つけて代入している

        Director = GameObject.Find("Director");


        //そのDirectorからGame_Directorスクリプトを参照して代入している
        //「オブジェクト名.GetComponent<スクリプト名>()」で参照できる
        //publicで作った変数を呼びたいなら更にその後ろに「.変数名」で参照できる

        G_Director = Director.GetComponent<Game_Director>();

        rb = GetComponent<Rigidbody2D>();//物理判定代入
    }



    void Update()
    {
        //入力受付
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
    }


    //FidedUpdateは「フレーム毎」に処理されるタイプのUpdate
    //「スペックの違うPCで動かしたらバグる！」ってならないようにできるぞ！
    //ちなみにキーボード入力とかをここで処理すると
    //フレームに合わせて押さないと反応しなくなったりするので注意だ！
    void FixedUpdate()
    {
        //移動処理
        //無入力であればベクトルを無くす、そうでなければ移動
        if(Horizontal == 0 && Vertical == 0)
        {
            rb.velocity = new Vector2(0,0);
        }
        else
        {
            rb.velocity = new Vector2(Horizontal, Vertical).normalized * speed;
        }
    }



    //スタートは開始時、Updateは常に呼ばれる処理なのと同じで、
    //「Ontrigger」も接触関係で自動的に呼ばれる処理
    //その後ろが「Enter」なら「重なった時」に呼ばれ、
    //「Stay」なら「重なっている間」に呼ばれ、
    //「Exit」なら「重なんなくなった時」に呼ばれる。英語の意味そのまんま。
    //2Dは2Dゲームの処理だから付いてる。3Dの時は書かなくていいよ

    //(Collider2D collider)
    //重なったオブジェクトの「Collider2D」を「collider」に格納している。
    //なのでこの処理内では　collider = 重なってる奴　として扱える。
    //ちなみにこれはintやfloatのように「Collider2D」って形の変数だから、
    //Hierarchyに置いてあるようなGameObjectではなく、
    //そのGameObjectの中身のColliderを指してるので注意

    //だからif文の所で
    //「collider.gameObject.tag」で「このコライダーを持ってる、ゲームオブジェクトの、タグ」
    //って指示する必要があったんですね^^

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 物体がトリガーに接触しとき、１度だけ呼ばれる
        Debug.Log("b");

        //接触したオブジェクトのタグが"Item"のとき
        if (collision.gameObject.tag == ("Item"))
        {
            Debug.Log("アイテムゲット！");

            //「この当たったコリジョンを持つ、ゲームオブジェクトの、Itemスクリプト内にある、Scoreの値」
            //をこのスクリプトが持ってるScoreに代入している
            Score = collision.gameObject.GetComponent<Item>().Score;//スコアを取得



            //(Score)　←これがよく聞くであろう伝説の「戻り値」
            //Game_DirectorスクリプトにあるScore_Updateを呼び出しているのだが、
            //あいつはScoreの数値を持っていないから何点を表示すればいいのかわからない...
            //Scoreを表示するって事しか知らんのだ。
            //そこで普段は何も書いてないvoidの()に処理内で必要な物、今回はScoreを要求する。
            //そしてその処理を参照するココで「自分の持ってるScore」を当てはめてあげる。
            //するとこのScoreを自分の持ってるScoreで処理して「戻ってくる」のだ！

            G_Director.Score_Update(Score);//スコアを反映
        }
    }
}
