using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject helicopter = GameObject.FindGameObjectWithTag("helicopterTag");
        float helicopterX = helicopter.transform.position.x + 5;
        transform.position = new Vector3(helicopterX, 1.5f, transform.position.z);
	}
    
}
