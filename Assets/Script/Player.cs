using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    //移動ステ
    private float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        //移動キー
        if (Input.GetKey("a"))
        {
            position.x -= speed;
        }
        else if (Input.GetKey("d"))
        {
            position.x += speed;
        }
        if (Input.GetKey("w"))
        {
            position.y += speed;
        }
        if (Input.GetKey("s"))
        {
            position.y -= speed;
        }

        transform.position = position;
    }
}
