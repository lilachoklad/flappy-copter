using UnityEngine;
using System.Collections;

public class ScoreSignController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject helicopter = GameObject.FindGameObjectWithTag("helicopterTag");
        float helicopterX = helicopter.transform.position.x - 2.4f;
        //float helicopterY = helicopter.transform.position.y;
        transform.position = new Vector3(helicopterX, transform.position.y, transform.position.z);

    }
}
