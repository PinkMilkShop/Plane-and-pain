using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int ScoreTracker = 0;
    public Text ScoreText;

    public void AddOne()
    {
        ScoreTracker += 1;
        ScoreText.text =   "Coins: " + ScoreTracker.ToString() + " / 40";
    }
}
