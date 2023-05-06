using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerCount : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        DisplayTime(currentTime);
        
    }
    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
