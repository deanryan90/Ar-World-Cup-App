using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerseyRotation : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
    }

    private float rotSpeed = 100;

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnMouseDrag()
    {
        float rotx = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        //float roty = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotx);
        //transform.Rotate(Vector3.right, roty);
    }
}