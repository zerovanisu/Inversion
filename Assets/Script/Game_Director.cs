using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Director : MonoBehaviour
{
    //[Header("�R�����g")]��Inspector��ɃR�����g��\���ł���
    //[SerializeField]��public����Ȃ��Ă�Inspector��ɕ\���ł���

    [SerializeField]
    Text Gamescoer;


    //�X�R�A�\�L���X�V���鏈��(�v���C���[���Ăяo��)
    public void Score_Update(int Score)
    {
        Gamescoer.text = "scoer" + Score;
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
}
