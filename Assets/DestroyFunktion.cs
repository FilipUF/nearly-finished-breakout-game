using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFunktion : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        GameObject othergameobjekt = collision.gameObject;
        BlockHealth hitEnemy = othergameobjekt.GetComponent<BlockHealth>();

        if (hitEnemy != null)
        {
            hitEnemy.TakeDamage();
        }
        
    }
}

