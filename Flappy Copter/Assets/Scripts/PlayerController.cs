using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Rigidbody rb;
    public float power;
    public float speed;
    public static int count;
    public Text countText;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCounterText();
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

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "point")
        {
            count++;
            SetCounterText();
        }

        if (other.gameObject.tag == "extrapoint")
        {
            other.gameObject.SetActive(false);
            count++;
            SetCounterText();
        }
    }

    void SetCounterText()
    {
        countText.text = "Poäng: " + count.ToString();
    }
}