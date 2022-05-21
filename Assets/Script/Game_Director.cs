using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Director : MonoBehaviour
{
    //[Header("�R�����g")]��Inspector��ɃR�����g��\���ł���
    //[SerializeField]��public����Ȃ��Ă�Inspector��ɕ\���ł���

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
        //UI�����Z�b�g����
        Deth_UI.SetActive(false);
        Clear_UI.SetActive(false);

        Aitem_No = Item_All.transform.childCount;
    }

    //�X�R�A�\�L���X�V���鏈��(�v���C���[���Ăяo��)
    public void Score_Update(int Score)
    {
        Gamescoer.text = "scoer" + Score;

        Aitem_No -= 1;

        if(Aitem_No == 0)
        {
            Clear_UI.SetActive(true);
        }
    }
    
    //���悭�����߂�l���Ă�B
    //�Ⴆ��RPG�Ń_���[�W����������Ƃ��Ƀ_���[�W�̌v�Z��������킯���B
    //void �_���[�W�v�Z () { ���� }�@�݂����ɁB
    //�����ǍU���͂�h��͂Ƃ��̐��l�̓v���C���[�Ƃ����̃X�N���v�g�����Ȃ���΂����Ȃ��B
    //�Ȃ̂�()�ɂ͏����ɕK�v�ȕϐ���p�ӂ��Ă����B
    //�_���[�W�v�Z ( int Atck, int HP )�@�݂����ɁB
    //��ł��̎����v���C���[�Ƃ����ĂԂƂ��Ɂ@�_���[�W�v�Z (�U����,�@�̗�);
    //���Ď����̎����Ă�������Ȃ��玮���ĂԂƁA�Ă΂ꂽ��̎��ɍU���͂�̗͂������p�����
    //���̂܂܌v�Z���āu�߂��Ă���v�Ƃ����킯���B


    public void GameOver()
    {
        //�Q�[���I�[�o�[UI��\��
        Deth_UI.SetActive(true);
    }

    public void Title_Change()
    {
        SceneManager.LoadScene("Title_Scene");
    }
}
