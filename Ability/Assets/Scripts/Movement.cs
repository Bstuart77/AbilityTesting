using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float moveSpeed = 30f;
    private Rigidbody rb;
    private float rotateX = 1.0f;
    private float rotateY = 1.0f;
    private float test;
    private float test2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
               transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);


        test += rotateX * Input.GetAxis("Mouse X");
        test2 -= rotateY * Input.GetAxis("Mouse Y");
        test2 = Mathf.Clamp(test2, -100f, 100f);
        transform.eulerAngles = new Vector3(test2, test, 0.0f);
    }
}
