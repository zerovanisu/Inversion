using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkWizark : MonoBehaviour
{
     private Vector2 pos;
public int num = 1;

void Update()
{
    pos = transform.position;

    // （ポイント）マイナスをかけることで逆方向に移動する。
    transform.Translate(transform.right * Time.deltaTime * 7 * num);

    if (pos.x > 4)
    {
        num = -1;
    }
    if (pos.x < -2)
    {
        num = 1;
    }
}
}