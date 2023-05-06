using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    [SerializeField] ParticleSystem goalBurst = null;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == "Goal")
        {
            Destroy(gameObject, .2f);
            goalBurst.Play();
            
            SceneManager.LoadScene(0);
        }
        if (other.name == "Floor")
        {
            AudioManager.instance.Stop("Level1_1Theme");
            SceneManager.LoadScene(0);
        }


    }

    void BackToLevelSelect()
    {
        
    }
}
