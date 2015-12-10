using UnityEngine;
using System.Collections;

public class PowerUpRotator : MonoBehaviour {

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
        GameObject extrapoint = GameObject.FindGameObjectWithTag("extrapoint");
        randomBitPosition(extrapoint);
        GameObject extraspeed = GameObject.FindGameObjectWithTag("extraspeed");
        randomBitPosition(extraspeed);
    }

    private void randomBitPosition(GameObject extrapoint)
    {
        float extrapointZ = extrapoint.transform.position.z;
        extrapoint.transform.position = new Vector3(Random.Range(26, 40), Random.Range(6.5F, -2.4F), extrapointZ);
    }
}
