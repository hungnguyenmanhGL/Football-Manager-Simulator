using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCamera : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
        MoveForwardOnKey(v);
    }

    void MoveForwardOnKey(float v)
    {
        if (v > 0)
        {
            Vector3 pos = transform.position;
            pos.z += moveSpeed * Time.deltaTime;
            transform.position = pos;
        }
        
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    ProcessCollision();
    //}

    //void ProcessCollision()
    //{
    //    Debug.Log("Collided");
    //}
}
