using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectCube : MonoBehaviour
{
    bool gameEnd = false;
    [SerializeField] GameObject gameEndScreen; 
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Scoring.theScore += 1;
        Destroy(other.gameObject);

    }

    void Update()
    {
        if(Scoring.theScore == 8 && gameEnd == false)
        {
            GameEnder();
        }
        if (gameEnd == true && Input.GetKeyDown(KeyCode.R))
        {
            gameEnd = false;
            SceneManager.LoadScene(0);
            Scoring.theScore = 0;
            gameEndScreen.SetActive(false);
        }
    }
    
    void GameEnder()
    {
        gameEndScreen.SetActive(true);
        gameEnd = true;
    }    
 }
