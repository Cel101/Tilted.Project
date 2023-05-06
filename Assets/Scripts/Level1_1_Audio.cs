using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1_1_Audio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.Play("Level1_1Theme");
    }
}
