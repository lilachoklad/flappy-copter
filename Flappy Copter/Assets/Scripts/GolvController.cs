using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GolvController : MonoBehaviour {

    private bool gameLost = false;
   public Text restartText;

    // Use this for initialization
    void Start () {
      restartText.text = "";
        gameLost = false;
    }
	

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "helicopterTag")
        {
            Time.timeScale = 0;
            gameLost = true;
            //så helikoptern inte ramlar ner utanför bild när spelet är slut
            //float helicopterX = other.transform.position.x;
            //float helicopterZ = other.transform.position.z;
            //float helicopterY = gameObject.transform.position.y;
           // other.transform.position = new Vector3(helicopterX, helicopterY, helicopterZ);
          restartText.text = "Klicka på mellanslag för att spela igen";
        }
    }

    // Update is called once per frame
    void Update() {
        if (gameLost == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Application.LoadLevel(0);
                Time.timeScale = 1;
            }
        }
    }
}
