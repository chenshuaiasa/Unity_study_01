using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform playertransform;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //playertransform = GetComponent<Transform>();
        //Debug.Log(playertransform);
        offset = transform.position - playertransform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = playertransform.position + offset;
    }
}
