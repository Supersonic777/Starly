using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HightScore : MonoBehaviour
{
    public int score;
    public Text hightScoreText;
    void Start()
    {
      score = PlayerPrefs.GetInt("HIGHTSCORE");  
      score = 0;
      if(PlayerPrefs.HasKey("HIGHTSCORE"))
      {
          PlayerPrefs.GetInt("HIGHTSCORE");
      }  
      StartCoroutine(ScoreGO()); 
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("HIGHTSCORE", score);
        PlayerPrefs.Save();
        hightScoreText.text = "HIGHTSCORE: " + score;
    }
    void Repeat()
    {
        StartCoroutine(ScoreGO());
    }
    IEnumerator ScoreGO()
    {
        yield return new WaitForSeconds(0.5f);
        score +=1;
        Repeat();
    }
}
