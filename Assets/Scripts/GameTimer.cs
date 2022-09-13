using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Our level timer in seconds")]
    [SerializeField] private float levelTime = 10f;

    private bool triggeredLevelFinished = false;

    private void Update()
    {
        if (triggeredLevelFinished)
        {
            return;
        }
        
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        bool timerFinished = Time.timeSinceLevelLoad >= levelTime;
        if (timerFinished)
        {
            FindObjectOfType<LevelController>().LevelTimerFinished();
            triggeredLevelFinished = true;
        }
    }
}
