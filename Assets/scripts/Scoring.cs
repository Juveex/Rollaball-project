using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoring : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    public static int theScore;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = theScore.ToString();
    }
}
