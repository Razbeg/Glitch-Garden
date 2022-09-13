using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject.GetComponent<Gravestone>())
        {
            GetComponent<Animator>().SetTrigger("JumpTrigger");
        }
        else if (gameObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(gameObject);
        }
    }
}
