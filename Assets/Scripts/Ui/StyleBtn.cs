using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StyleBtn : MonoBehaviour
{
    public void OnPointerClick()
    {
        Debug.Log("OnPointerClick");
        AudioManager.Instance.PlaySound(AudioManager.Instance.interfaceClick);
    }
}
