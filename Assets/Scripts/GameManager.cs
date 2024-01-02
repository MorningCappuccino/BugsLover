using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _bugsCount = 0;

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
        _bugsCount++;
        float jumpForce = CharacterController2DMod.Instance.GetDefaultJumpForce();
        CharacterController2DMod.Instance.SetJumpForce(jumpForce - (_bugsCount * (10 * _bugsCount)));
        Debug.Log("jumpForce: " + CharacterController2DMod.Instance.GetJumpForce());
    }
}
