using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishDoor : MonoBehaviour
{
    [SerializeField] private GameObject _winScreen;

    public static Action StarRating;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            CheckWin();
        }
    }

    private void CheckWin()
    {
        _winScreen.SetActive(true);

        StarRating.Invoke();
    }
}
