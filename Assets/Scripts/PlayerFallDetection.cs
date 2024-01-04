using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallDetection : MonoBehaviour
{

    [SerializeField] private GameObject GameOverScreen;

    bool detected = false;

    void Update()
    {
        if (!detected && transform.position.y < -10)
        {
            // GameManager.Instance.GameOver();
            GameOverScreen.SetActive(true);
            detected = true;
        }
    }
}
