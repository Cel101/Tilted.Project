using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerScore : MonoBehaviour
{
    public int StarsCollected { get; private set; }
    public UnityEvent<PlayerScore> OnStarCollected;

    public void StarCollected()
    {
        StarsCollected++;
        OnStarCollected.Invoke(this);
    }
}
