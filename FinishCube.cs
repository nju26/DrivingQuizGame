using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishCube : MonoBehaviour
{
    public GameObject score;
    public GameObject bestscore;
    public GameObject Time;
    public GameObject bestTime;

    public GameObject panel;
    public GameObject rawima;
    public GameObject rawima1;
    public GameObject rawima2;



    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            score.GetComponent<Text>().text = "Score: " + AnswerButtons.scoreValue;
            bestscore.GetComponent<Text>().text = "Best: " + AnswerButtons.bestScore;


            StartCoroutine(CalculateScore());
        }
    }

    IEnumerator CalculateScore()
    {
        rawima.SetActive(true);
        yield return new WaitForSeconds(1f);
        panel.SetActive(true);
        yield return new WaitForSeconds(1f);

        score.SetActive(true);
        yield return new WaitForSeconds(1f);
        bestscore.SetActive(true);
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("MainMenu");
    }
}
