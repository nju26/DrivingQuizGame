using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizTrigger : MonoBehaviour
{
    public GameObject quizUI;
    private bool hasDisplayedQuiz = false;

    private void OnTriggerStay(Collider other)
    {
        if (!hasDisplayedQuiz && other.CompareTag("Player"))
        {
            quizUI.SetActive(true);
            hasDisplayedQuiz = true;
        }
    }
}

