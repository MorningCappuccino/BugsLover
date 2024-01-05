using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static UIController Instance;

    [SerializeField] private TextMeshProUGUI _bugsCountText;
    [SerializeField] private TextMeshProUGUI _scoreCountText;

    private void Awake() {
        Instance = this;
    }

    public void SetBugsCountText(int count)
    {
        _bugsCountText.text = count.ToString();
    }

    public void SetScoreCountText(int count)
    {
        _scoreCountText.text = count.ToString();
    }

    public void BtnSoundOnClick()
    {
        Debug.Log("BtnSoundOnClick");
        AudioManager.Instance.PlaySound(AudioManager.Instance.interfaceClick);
    }
}
