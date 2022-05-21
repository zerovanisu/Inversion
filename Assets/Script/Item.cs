using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //[Header("�R�����g")]��Inspector��ɃR�����g��\���ł���
    //[SerializeField]��public����Ȃ��Ă�Inspector��ɕ\���ł���
    [Header("���Z�����X�R�A")]
    [SerializeField]
    public int Score;

    //�A�C�e���̔�
    SpriteRenderer Item_Coller { get; set; }

    [Header("�_�ő��x")]
    [SerializeField]
    float Fead_Speed;

    //�F�p�̐��l
    [SerializeField]
    float R, G, B, A;

    //�_�Ő؂�ւ��̃X�C�b�`
    [SerializeField]
    bool Fead;

    private void Start()
    {
        Item_Coller = GetComponent<SpriteRenderer>();

        //R,G,B��Alpha�l(�����x)����
        R = Item_Coller.color.r;
        G = Item_Coller.color.g;
        B = Item_Coller.color.b;
        A = Item_Coller.color.a;
    }


    //FidedUpdate�́u�t���[�����v�ɏ��������^�C�v��Update
    //�u�X�y�b�N�̈ႤPC�œ���������o�O��I�v���ĂȂ�Ȃ��悤�ɂł��邼�I
    //���Ȃ݂ɃL�[�{�[�h���͂Ƃ��������ŏ��������
    //�t���[���ɍ��킹�ĉ����Ȃ��Ɣ������Ȃ��Ȃ����肷��̂Œ��ӂ��I
    private void FixedUpdate()
    {
        //�_�ŏ���
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

        //�F�𔽉f
        Item_Coller.color = new Color(R,G,B,A);
    }


    //�X�^�[�g�͊J�n���AUpdate�͏�ɌĂ΂�鏈���Ȃ̂Ɠ����ŁA
    //�uOntrigger�v���ڐG�֌W�Ŏ����I�ɌĂ΂�鏈��
    //���̌�낪�uEnter�v�Ȃ�u�d�Ȃ������v�ɌĂ΂�A
    //�uStay�v�Ȃ�u�d�Ȃ��Ă���ԁv�ɌĂ΂�A
    //�uExit�v�Ȃ�u�d�Ȃ�Ȃ��Ȃ������v�ɌĂ΂��B�p��̈Ӗ����̂܂�܁B
    //2D��2D�Q�[���̏���������t���Ă�B3D�̎��͏����Ȃ��Ă�����[

    //(Collider2D collider)
    //�d�Ȃ����I�u�W�F�N�g�́uCollider2D�v���ucollider�v�Ɋi�[���Ă���B
    //�Ȃ̂ł��̏������ł́@collider = �d�Ȃ��Ă�z�@�Ƃ��Ĉ�����B
    //���Ȃ݂ɂ����int��float�̂悤�ɁuCollider2D�v���Č`�̕ϐ�������A
    //Hierarchy�ɒu���Ă���悤��GameObject�ł͂Ȃ��A
    //����GameObject�̒��g��Collider���w���Ă�̂Œ���

    //������if���̏���
    //�ucollider.gameObject.tag�v�Łu���̃R���C�_�[�������Ă�A�Q�[���I�u�W�F�N�g�́A�^�O�v
    //���Ďw������K�v����������ł���^^

    private void OnTriggerEnter2D(Collider2D collider)
    {
        // ���̂��A�C�e���ɐڐG�����Ƃ��A��x�����Ă΂��
        Debug.Log("b");

        // �ڐG�����̂��v���C���[�̏ꍇ
        if (collider.gameObject.tag == ("Player"))
        {
            //����(����.�Q�[���I�u�W�F�N�g��)
            Destroy(this.gameObject);   
        }

    }
}
