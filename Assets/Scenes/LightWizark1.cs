using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightWizark1 : MonoBehaviour
{
    private Vector2 pos;
    public int num = 1;

    void Update()
    {
        pos = transform.position;

        // �i�|�C���g�j�}�C�i�X�������邱�Ƃŋt�����Ɉړ�����B
        transform.Translate(transform.right * Time.deltaTime * 2 * num);

        if (pos.x > 7)
        {
            num = -1;
        }
        if (pos.x < -9)
        {
            num = 1;
        }
    }
}