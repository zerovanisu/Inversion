using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Director : MonoBehaviour
{
    //[Header("コメント")]でInspector上にコメントを表示できる
    //[SerializeField]でpublicじゃなくてもInspector上に表示できる

    [SerializeField]
    Text Gamescoer;


    //スコア表記を更新する処理(プレイヤーが呼び出す)
    public void Score_Update(int Score)
    {
        Gamescoer.text = "scoer" + Score;
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
}
