using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int hp = 1;
    // Update is called once per frame
    public void TakeDamage()
    {
        hp -= 1;
        if (hp==0)
        {
            Destroy(gameObject);
        }
    }
}
