using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRating : MonoBehaviour
{
    [SerializeField] private GameObject star_1;
    [SerializeField] private GameObject star_2;
    [SerializeField] private GameObject star_3;

    private void OnEnable() {
        FinishDoor.StarRating += Rate;
    }

    private void OnDisable() {
        FinishDoor.StarRating += Rate;
    }

    private void Rate()
    {
        Debug.Log("CheckWin");

        switch (GameManager.Instance.GetScoreCount()) {
            case 250:
            case 200:
                star_1.SetActive(true);
                star_2.SetActive(true);
                star_3.SetActive(true);
                break;
            case 150:
                star_1.SetActive(true);
                star_2.SetActive(true);
                break;
            case 100:
            case 50:
                star_1.SetActive(true);
                break;
        }
    }
}
