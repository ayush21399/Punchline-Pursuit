using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float totalTime = 60f;
    public Button startButton;

    private float currentTime;

    void Start()
    {
        startButton.onClick.AddListener(StartQuiz);
        currentTime = totalTime;
        
    }

    IEnumerator StartTimer()
    {
        while (currentTime > 0)
        {
            timerText.text = $"Time: {Mathf.Round(currentTime)}s";
            yield return new WaitForSeconds(1f);
            currentTime--;
        }

        timerText.text = "Time's up!";
       
    }
    private void StartQuiz()
    {
        StartCoroutine(StartTimer());
    }
}