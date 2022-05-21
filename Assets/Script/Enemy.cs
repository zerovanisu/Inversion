using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector2 pos;

    [SerializeField]
    int Left, Right;

    [SerializeField]
    float speed;

    [SerializeField]
    private float Vec;

    SpriteRenderer Enemy_Coller { get; set; }

    //�F�p�̐��l
    [SerializeField]
    float R, G, B, A;

    //�_�Ő؂�ւ��̃X�C�b�`
    [SerializeField]
    bool Change;
    private void Start()
    {
        Enemy_Coller = GetComponent<SpriteRenderer>();

        //R,G,B��Alpha�l(�����x)����
        R = Enemy_Coller.color.r;
        G = Enemy_Coller.color.g;
        B = Enemy_Coller.color.b;
        A = Enemy_Coller.color.a;
        Vec = speed;
    }

    void FixedUpdate()
    {
        pos = transform.position;

        if (pos.x > Right)
        {
            Vec = -speed;
        }
        if (pos.x < Left)
        {
            Vec = speed;
        }

        // �i�|�C���g�j�}�C�i�X�������邱�Ƃŋt�����Ɉړ�����B
        transform.Translate(transform.right * Time.deltaTime * Vec);


        if (Change == true)
        {
            R = G = B = 1;
        }
        else
        {
            R = G = B = 0;
        }
    }
}
