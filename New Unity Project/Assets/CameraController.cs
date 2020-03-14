using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public bool useOffsetValues;
    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        if (!useOffsetValues)
        {
            offset = target.position - transform.position;
        }

    }

    // Update is called once per frame
    void Update()
    {
        //get x position of mouse & rotate the target
        float horizontal = Input.GetAxis("MouseX")*rotateSpeed;
        target.Rotate(0, )
        transform.position = target.position - offset;
        transform.LookAt(target);
    }
}
