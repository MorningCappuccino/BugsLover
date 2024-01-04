using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace BugsLover.UI
{
    public class Menu : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] private string gameScene;

        [Header("Ui")]
        [SerializeField] private Button startBtn;
        [SerializeField] private Button quitBtn;

        private void OnEnable()
        {
            startBtn.onClick.AddListener(StartClick);
            quitBtn.onClick.AddListener(QuitClick);
        }

        private void StartClick()
        {
            SceneManager.LoadScene(gameScene);
        }

        private void QuitClick()
        {
            Application.Quit();
        }

        private void OnDisable()
        {
            startBtn.onClick.RemoveListener(StartClick);
            quitBtn.onClick.RemoveListener(QuitClick);
        }
    }
}