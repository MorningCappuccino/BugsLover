using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void OnEnable()
    {
        Bug.OnBugGrab += OnBugGrab;
    }

    private void OnDisable()
    {
        Bug.OnBugGrab -= OnBugGrab;
    }

    private void OnBugGrab() 
    {
        Debug.Log("OnBugGrub");
    }
}
