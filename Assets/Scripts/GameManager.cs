using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject _winScreen;

    private int _bugsCount = 0;
    public int GetBugsCount() => _bugsCount;
    public void AddBugs(int count)
    {
        _bugsCount += count;
        UIController.Instance.SetBugsCountText(_bugsCount);
    }

    private int _scoreCount = 0;
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

    public void CheckWin()
    {
        Debug.Log("CheckWin");

        switch (_scoreCount) {
            case 250:
            case 200:
                Debug.Log("3 stars"); 
                break;
            case 150:
                Debug.Log("2 stars"); 
                break;
            case 100:
            case 50:
                Debug.Log("1 stars"); 
                break;
        }

        _winScreen.SetActive(true);
    }
}
