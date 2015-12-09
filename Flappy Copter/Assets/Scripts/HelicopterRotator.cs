using UnityEngine;
using System.Collections;

public class HelicopterRotator : MonoBehaviour {

    public int rotateSpeed = 20;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 5, 0) * Time.deltaTime * rotateSpeed);
    }
}
