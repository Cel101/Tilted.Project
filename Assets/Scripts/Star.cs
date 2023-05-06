using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerScore playerScore = other.GetComponent<PlayerScore>();
        if (playerScore != null)
        {
            playerScore.StarCollected();
            gameObject.SetActive(false);
        }
    }
}
