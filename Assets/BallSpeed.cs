using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeed : MonoBehaviour
{

    Rigidbody myRigibody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myRigibody = GetComponent<Rigidbody>();
        float speed = 4;
        myRigibody.velocity = myRigibody.velocity.normalized * speed;
    }
}
