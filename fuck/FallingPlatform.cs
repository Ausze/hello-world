using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public float FallingTime = 1;//玩家触碰后多少秒掉落或者消失

    public TargetJoint2D _targetJoint2D;

    public BoxCollider2D _boxCollider2D;
    // Start is called before the first frame update
    void Start()
    {
        _targetJoint2D = GetComponent<TargetJoint2D>();
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Invoke("Falling",FallingTime);//过多少秒调用Falling；
        }

        if (other.gameObject.layer == 8) //第八层为Ground层，碰撞后消失
        {
            Destroy(gameObject);
        }
    }

    private void Falling()
    {
        _targetJoint2D.enabled = false;
        _boxCollider2D.isTrigger = false;
    }
}
