using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] private float baseLives = 3;
    [SerializeField] private int damage = 1;

    private Text livesText;
    private float lives;

    private void Start()
    {
        lives = baseLives - PlayerPrefController.GetDifficulty();
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void TakeLife()
    {
        lives -= damage;
        UpdateDisplay();

        if (lives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
