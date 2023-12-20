using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> questions;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject quizPanel;

    public TMP_Text QuestionText;

    private void Start() {
        GenerateQuestions();
    }

    public void Correct() {
        questions.RemoveAt(currentQuestion);
        GenerateQuestions();
    }

    private void SetAnswers() {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerQuiz>().isCorrect = false;
            options[i].transform.GetChild(2).GetComponent<TMP_Text>().text = questions[currentQuestion].Answers[i];

            if (questions[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerQuiz>().isCorrect = true;
            }
        }
    }

    private void GenerateQuestions()
    {
        if (questions.Count <= 0)
        {
            quizPanel.SetActive(false);
            return;
        }
            
        currentQuestion = UnityEngine.Random.Range(0, questions.Count);
        QuestionText.text = questions[currentQuestion].Question;

        SetAnswers();
    }

}
