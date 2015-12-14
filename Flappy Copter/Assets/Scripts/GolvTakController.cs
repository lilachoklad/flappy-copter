using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GolvTakController : MonoBehaviour {

    private bool gameLost = false;
    public Text restartText;
    public Text gameOverCountText;
    private static int score;
    public GameObject gameOverSkylt;

    // Use this for initialization
    void Start () {
        restartText.text = "";
        gameLost = false;
        gameOverCountText.text = "";
        if (gameOverSkylt != null) {
            gameOverSkylt.SetActive(false);
        }
        
    }
	

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "helicopterTag")
        {
            Time.timeScale = 0;
            gameLost = true;
            score = PlayerController.count;
            
            gameOverCountText.text = "Din poäng blev: " + score.ToString();
            restartText.text = "Klicka pà R för att spela igen";
        }
    }

    // Update is called once per frame
    void Update() {
        if (gameLost == true)
        {
            if (gameOverSkylt != null)
            {
                gameOverSkylt.SetActive(true);
            }
            
            GameObject helicopter = GameObject.FindGameObjectWithTag("helicopterTag");
            float helicopterX = helicopter.transform.position.x + 1;
            gameOverSkylt.transform.position = new Vector3(helicopterX, transform.position.y, transform.position.z);
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(0);
                Time.timeScale = 1;
            }
        }
    }
}
