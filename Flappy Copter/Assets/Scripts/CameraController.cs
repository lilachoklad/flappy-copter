using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject helicopter = GameObject.FindGameObjectWithTag("helicopterTag");
        float helicopterX = helicopter.transform.position.x;
        float helicopterY = helicopter.transform.position.y;
        transform.position = new Vector3(helicopterX, helicopterY, transform.position.z);
	}
    
}
