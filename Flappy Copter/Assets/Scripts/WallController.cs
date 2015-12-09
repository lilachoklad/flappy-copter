using UnityEngine;
using System.Collections;

public class WallController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        genereraRandomPosition();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void genereraRandomPosition () {
        //bit6 måste hämtas först för att den ska användas åt bit1
        GameObject uppebit6 = GameObject.FindGameObjectWithTag("uppebit6");
        GameObject nerebit6 = GameObject.FindGameObjectWithTag("nerebit6");

        //y-värdet på bit1 tas från y-värdet på bit6 för att det ska se likadant ut efter teleporteringen
        GameObject uppebit = GameObject.FindGameObjectWithTag("uppebit1");
        GameObject nerebit = GameObject.FindGameObjectWithTag("nerebit1");
        float uppebitX = uppebit.transform.position.x;
        float uppebitY = uppebit6.transform.position.y;
        float uppebitZ = uppebit.transform.position.z;
        uppebit.transform.position = new Vector3(uppebitX, uppebitY, uppebitZ);
        //y-värde för nerebiten
        float nerebitY = uppebit.transform.position.y - 4.5f - uppebit.transform.localScale.y;
        nerebit.transform.position = new Vector3(uppebitX, nerebitY, uppebitZ);

        GameObject uppebit2 = GameObject.FindGameObjectWithTag("uppebit2");
        GameObject nerebit2 = GameObject.FindGameObjectWithTag("nerebit2");
        randomBitPosition(uppebit2, nerebit2);

        GameObject uppebit3 = GameObject.FindGameObjectWithTag("uppebit3");
        GameObject nerebit3 = GameObject.FindGameObjectWithTag("nerebit3");
        randomBitPosition(uppebit3, nerebit3);

        GameObject uppebit4 = GameObject.FindGameObjectWithTag("uppebit4");
        GameObject nerebit4 = GameObject.FindGameObjectWithTag("nerebit4");
        randomBitPosition(uppebit4, nerebit4);

        GameObject uppebit5 = GameObject.FindGameObjectWithTag("uppebit5");
        GameObject nerebit5 = GameObject.FindGameObjectWithTag("nerebit5");
        randomBitPosition(uppebit5, nerebit5);

       
        randomBitPosition(uppebit6, nerebit6);

        /*
        GameObject uppebit7 = GameObject.FindGameObjectWithTag("uppebit7");
        GameObject nerebit7 = GameObject.FindGameObjectWithTag("nerebit7");
        randomBitPosition(uppebit7, nerebit7);

        GameObject uppebit8 = GameObject.FindGameObjectWithTag("uppebit8");
        GameObject nerebit8 = GameObject.FindGameObjectWithTag("nerebit8");
        randomBitPosition(uppebit8, nerebit8);
        */

    }

    private void randomBitPosition (GameObject uppebit, GameObject nerebit) {
        float uppebitX = uppebit.transform.position.x;
        float uppebitZ = uppebit.transform.position.z;
        uppebit.transform.position = new Vector3(uppebitX, Random.Range(4.76F, 9.76F), uppebitZ);

        float nerebitY = uppebit.transform.position.y - 4.5f - uppebit.transform.localScale.y;
        nerebit.transform.position = new Vector3(uppebitX, nerebitY, uppebitZ);
    }

}
