using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace BugsLover.UI
{
    public class PausePanel : MonoBehaviour
    {
        [SerializeField] private string quitScene;
        [SerializeField] private Button resumeBtn;
        [SerializeField] private Button quitBtn;

        private void OnEnable()
        {
            Time.timeScale = 0f;
            resumeBtn.onClick.AddListener(ResumeClick);
            quitBtn.onClick.AddListener(QuitClick);
        }

        private void QuitClick()
        {
            SceneManager.LoadScene(quitScene);
        }

        private void ResumeClick()
        {
            gameObject.SetActive(false);
        }

        private void OnDisable()
        {
            Time.timeScale = 1f;
            resumeBtn.onClick.RemoveListener(ResumeClick);
            quitBtn.onClick.RemoveListener(QuitClick);
        }
    }
}