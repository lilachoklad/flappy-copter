using UnityEngine;
using System.Collections;

public class WallController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject uppebit = GameObject.FindGameObjectWithTag("uppebit1");        
        GameObject nerebit = GameObject.FindGameObjectWithTag("nerebit1");
        randomBitPosition(uppebit, nerebit);

        GameObject uppebit2 = GameObject.FindGameObjectWithTag("uppebit2");        
        GameObject nerebit2 = GameObject.FindGameObjectWithTag("nerebit2");
        randomBitPosition(uppebit2, nerebit2);

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void randomBitPosition (GameObject uppebit, GameObject nerebit) {
        float uppebitX = uppebit.transform.position.x;
        float uppebitZ = uppebit.transform.position.z;
        uppebit.transform.position = new Vector3(uppebitX, Random.Range(4.76F, 9.76F), uppebitZ);

        float nerebitY = uppebit.transform.position.y - 3.5f - uppebit.transform.localScale.y;
        nerebit.transform.position = new Vector3(uppebitX, nerebitY, uppebitZ);
    }

}
