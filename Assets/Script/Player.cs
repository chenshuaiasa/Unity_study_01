using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("游戏开始了");
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("游戏正在运行");
        //
        //rb.AddForce(Vector3.right);
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis ("Vertical");
        float j = Input.GetAxis("Jump");
        //Debug.Log(h);

        rb.AddForce(new Vector3(h,j*4, v)*2);

    }
}
