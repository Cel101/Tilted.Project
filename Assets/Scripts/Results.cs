using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Results : MonoBehaviour
{
    public TextMeshProUGUI starText;
    public TextMeshProUGUI timeText;
    public void ResultValues(float time, int stars)
    {
        gameObject.SetActive(true);
        starText.text = stars.ToString();
        timeText.text = time.ToString();
    }
}
