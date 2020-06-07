using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acid : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //玩家掉入酸液中销毁
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == 9) //这里设置Player层
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.layer == 10)//这里设置为Enemy层
        {
            Destroy(other.gameObject);
        }
    }
}
