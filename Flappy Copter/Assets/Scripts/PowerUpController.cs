using UnityEngine;
using System.Collections;

public class PowerUpController : MonoBehaviour {

    public int rotateSpeed = 3;

    // Use this for initialization
    void Start () {
        genereraRandomPosition();
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * rotateSpeed);
    }

    public void genereraRandomPosition()
    {
        float powerupZ = transform.position.z;
        transform.position = new Vector3(Random.Range(17, 95), Random.Range(5.8F, -2.8F), powerupZ);
    }

}
