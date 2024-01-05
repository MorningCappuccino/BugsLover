using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int _bugsCount = 0;
    public int GetBugsCount() => _bugsCount;
    public void AddBugs(int count)
    {
        _bugsCount += count;
        UIController.Instance.SetBugsCountText(_bugsCount);
    }

    private int _scoreCount = 0;
    public int GetScoreCount() => _scoreCount;
    public void AddScore(int count)
    {
        _scoreCount += count;
        UIController.Instance.SetScoreCountText(_scoreCount);
    }

    private void Awake() {
        Instance = this;
    }

    private void OnEnable()
    {
        Bug.OnBugGrab += OnBugGrab;
        BugBullet.OnBugGrab += OnBugGrab;
    }

    private void OnDisable()
    {
        Bug.OnBugGrab -= OnBugGrab;
        BugBullet.OnBugGrab -= OnBugGrab;
    }

    private void OnBugGrab() 
    {
        AddBugs(1);
        AddScore(50);
        float jumpForce = CharacterController2DMod.Instance.GetDefaultJumpForce();
        CharacterController2DMod.Instance.SetJumpForce(jumpForce - (_bugsCount * (10 * _bugsCount)));
        // Debug.Log("jumpForce: " + CharacterController2DMod.Instance.GetJumpForce());
    }
}
