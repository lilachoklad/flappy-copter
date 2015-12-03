using UnityEngine;
using System.Collections;

public class TeleportController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //när helikoptern går emot boxcollidern ska den teleporteras till ursprungliga positionen

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("ontriggerenter");
        if (other.gameObject.tag == "helicopterTag")
        {
            Debug.Log("ifsatsen");
            GameObject helicopter = GameObject.FindGameObjectWithTag("helicopterTag");
            float helicopterY = helicopter.transform.position.y;
            float helicopterZ = helicopter.transform.position.z;
           // var player = GameObject.Find("helikopter");
            other.transform.position = new Vector3(-6.71f, helicopterY, helicopterZ);
        }
    }
}
