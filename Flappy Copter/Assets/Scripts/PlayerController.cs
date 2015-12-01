using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Rigidbody rb;
    public float power;
    public float speed;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //rb.AddForce(transform.up * power, ForceMode.Impulse);
            rb.velocity = new Vector3(speed, power, rb.velocity.z);
        }

        rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);
    }
}