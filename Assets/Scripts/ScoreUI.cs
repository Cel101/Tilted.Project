using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    private TextMeshProUGUI starText;

    void Start()
    {
        starText = GetComponent<TextMeshProUGUI>();
        
    }
    public void UpdateStarText(PlayerScore playerScore)
    {
        starText.text = playerScore.StarsCollected.ToString();
    }
}
