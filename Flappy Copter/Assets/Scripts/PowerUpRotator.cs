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
        GameObject extraspeed = GameObject.FindGameObjectWithTag("extraspeed");
        randomBitPosition(extrapoint, extraspeed);
    }

    private void randomBitPosition(GameObject extrapoint, GameObject extraspeed)
    {
        float extrapointZ = extrapoint.transform.position.z;
        extrapoint.transform.position = new Vector3(Random.Range(17, 95), Random.Range(5.8F, -2.8F), extrapointZ);

        float extraspeedZ = extraspeed.transform.position.z;
        extraspeed.transform.position = new Vector3(Random.Range(17, 95), Random.Range(5.8F, -2.8F), extraspeedZ);
    }
}
