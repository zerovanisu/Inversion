using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Director : MonoBehaviour
{
    //[Header("コメント")]でInspector上にコメントを表示できる
    //[SerializeField]でpublicじゃなくてもInspector上に表示できる

    [SerializeField]
    Text Gamescoer;

    [SerializeField]
    GameObject Deth_UI;

    [SerializeField]
    GameObject Clear_UI;

    [SerializeField]
    GameObject Item_All;

    [SerializeField]
    int Aitem_No;

    private void Start()
    {
        //UIをリセットする
        Deth_UI.SetActive(false);
        Clear_UI.SetActive(false);

        Aitem_No = Item_All.transform.childCount;
    }

    //スコア表記を更新する処理(プレイヤーが呼び出す)
    public void Score_Update(int Score)
    {
        Gamescoer.text = "scoer" + Score;

        Aitem_No -= 1;

        if(Aitem_No == 0)
        {
            Clear_UI.SetActive(true);
        }
    }
    
    //↑よく聞く戻り値ってやつ。
    //例えばRPGでダメージ処理をするときにダメージの計算式があるわけだ。
    //void ダメージ計算 () { 処理 }　みたいに。
    //だけど攻撃力や防御力とかの数値はプレイヤーとか他のスクリプトを見なければいけない。
    //なので()には処理に必要な変数を用意しておく。
    //ダメージ計算 ( int Atck, int HP )　みたいに。
    //んでその式をプレイヤーとかが呼ぶときに　ダメージ計算 (攻撃力,　体力);
    //って自分の持ってる情報を入れながら式を呼ぶと、呼ばれた先の式に攻撃力や体力が引き継がれて
    //そのまま計算して「戻ってくる」というわけだ。


    public void GameOver()
    {
        //ゲームオーバーUIを表示
        Deth_UI.SetActive(true);
    }

    public void Title_Change()
    {
        SceneManager.LoadScene("Title_Scene");
    }
}
