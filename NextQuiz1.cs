using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextQuiz : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("quiz");
    }
   
}
