using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        // 物体がアイテムに接触したとき、一度だけ呼ばれる
        Debug.Log("b");
        // 接触したのがプレイヤーの場合
        if (collider.gameObject.tag == ("Player"))
        {
            Destroy(this.gameObject);   
        }

    }
}
