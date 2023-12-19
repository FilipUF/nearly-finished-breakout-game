using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KraftNeråt : MonoBehaviour
{
    Rigidbody bollbody;
    
    // Start is called before the first frame update
    void Start()
    {
        bollbody = GetComponent<Rigidbody>();
        transform.position = new Vector3(0, 2, 0);
        bollbody.AddForce(new Vector3(0, -10, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
