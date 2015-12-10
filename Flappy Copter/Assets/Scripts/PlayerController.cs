using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Rigidbody rb;
    public float power;
    public float speed;
    public static int count;
    public Text countText;
    public AudioClip helicopterSound;
    private AudioSource source;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCounterText();
        source = GetComponent<AudioSource>();
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

        if (rb.velocity.y > 0)
        {
            if (!source.isPlaying)
            {
                source.Play();
            }
        }
        else
        {
            source.Pause();
        }
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
        if (other.gameObject.tag == "extraspeed")
        {
            other.gameObject.SetActive(false);
            speed = 4;
            Invoke("ResetSpeed", 10.0f);
        }
    }

    void SetCounterText()
    {
        countText.text = "Poäng: " + count.ToString();
    }

    void ResetSpeed()
    {
        speed = 1;
    }

}