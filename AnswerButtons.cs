using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    public GameObject answerAbackBlue;
    public GameObject answerAbackGreen;
    public GameObject answerAbackRed;

    public GameObject answerBbackBlue;
    public GameObject answerBbackGreen;
    public GameObject answerBbackRed;

    public GameObject answerCbackBlue;
    public GameObject answerCbackGreen;
    public GameObject answerCbackRed;

    public GameObject answerDbackBlue;
    public GameObject answerDbackGreen;
    public GameObject answerDbackRed;

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    public GameObject currentScore;
    public static int scoreValue;
    public static int bestScore;
    public GameObject bestDisplay;
    public GameObject quizui;
    public GameObject blackScreen;
    void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScoreQuiz");
        bestDisplay.GetComponent<Text>().text = "Best:" + bestScore;
        blackScreen.SetActive(false);
    }

    void Update()
    {
        currentScore.GetComponent<Text>().text = "score:" + scoreValue;
    }

    public void AnswerA()
    {
        if (QuestionGenerate.actualAnswer == "A")
        {
            answerAbackGreen.SetActive(true);
            answerAbackBlue.SetActive(false);
            scoreValue += 5;

        }
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackBlue.SetActive(false);
            scoreValue = 0;
            StartCoroutine(DisplayBlackScreen());
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerB()
    {
        if (QuestionGenerate.actualAnswer == "B")
        {
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
            scoreValue += 5;

        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackBlue.SetActive(!false);
            scoreValue = 0;
            StartCoroutine(DisplayBlackScreen());
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());

    }

    public void AnswerC()
    {
        if (QuestionGenerate.actualAnswer == "C")
        {
            answerCbackGreen.SetActive(true);
            answerCbackBlue.SetActive(false);
            scoreValue += 5;

        }
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackBlue.SetActive(false);
            scoreValue = 0;
            StartCoroutine(DisplayBlackScreen());
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());

    }

    public void AnswerD()
    {
        if (QuestionGenerate.actualAnswer == "D")
        {
            answerDbackGreen.SetActive(true);
            answerDbackBlue.SetActive(false);
            scoreValue += 5;

        }
        else
        {
            answerDbackRed.SetActive(true);
            answerDbackBlue.SetActive(false);
            scoreValue = 0;
            StartCoroutine(DisplayBlackScreen());
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());

    }

    IEnumerator NextQuestion()
    {
        if(bestScore < scoreValue)
        {
            PlayerPrefs.SetInt("BestScoreQuiz", scoreValue);
            bestScore = scoreValue;
            bestDisplay.GetComponent<Text>().text = "Best:" + scoreValue;
        }
        yield return new WaitForSeconds(2);

        answerAbackGreen.SetActive(false);
        answerBbackGreen.SetActive(false);
        answerCbackGreen.SetActive(false);
        answerDbackGreen.SetActive(false);
        answerAbackRed.SetActive(false);
        answerBbackRed.SetActive(false);
        answerCbackRed.SetActive(false);
        answerDbackRed.SetActive(false);
        answerAbackBlue.SetActive(true);
        answerBbackBlue.SetActive(true);
        answerCbackBlue.SetActive(true);
        answerDbackBlue.SetActive(true);

        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;
        quizui.SetActive(false);
        QuestionGenerate.displayingQuestion = false;

    }
    IEnumerator DisplayBlackScreen()
    {
        blackScreen.SetActive(true);
        quizui.SetActive(false);
        yield return new WaitForSeconds(3);
        blackScreen.SetActive(false);

        EventSystem.current.SetSelectedGameObject(null);
    }

}
