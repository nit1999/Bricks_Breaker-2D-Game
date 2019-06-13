using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{

    public int score=0;
    public int Life=3;
    public Text ScoreText;
    public Text LifeText;
    public void ScoreCounter()
    {
        score += 5;
        ScoreText.text = "score :" + score;
    }
    public void LifeCounter()
    {
        Life -= 1;
        LifeText.text = "Life : " + Life;
    }
}
