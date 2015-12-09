using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GolvTakController : MonoBehaviour {

    private bool gameLost = false;
    public Text restartText;
    public Text gameOverCountText;
    private static int score;
    public GameObject wall;

    // Use this for initialization
    void Start () {
        restartText.text = "";
        gameLost = false;
        gameOverCountText.text = "";
        //GameObject gameOverSkylt = GameObject.FindGameObjectWithTag("gameOverSkylt");
        //gameOverSkylt.gameObject.SetActive(false);
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
            score = PlayerController.count;
            
            gameOverCountText.text = "Din poäng blev: " + score.ToString();
            restartText.text = "Klicka pà R för att spela igen";
        }
    }

    // Update is called once per frame
    void Update() {
        if (gameLost == true)
        {
            //GameObject gameOverSkylt = GameObject.FindGameObjectWithTag("gameOverSkylt");
            //gameOverSkylt.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(0);
                Time.timeScale = 1;
            }
        }
    }
}
