using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigidbody;
    private float speed = 500;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = Vector3.zero;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.velocity += new Vector3(0, 0, speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.velocity += new Vector3(-speed * Time.fixedDeltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.velocity += new Vector3(0, 0, -speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.velocity += new Vector3(speed * Time.fixedDeltaTime, 0, 0);
        }

        transform.LookAt(transform.position + rigidbody.velocity);
    }
}
