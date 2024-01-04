using UnityEngine;

public class Bug : MonoBehaviour
{
    public delegate void BugGrabDelegate();
    public static event BugGrabDelegate OnBugGrab;

    private void OnTriggerEnter2D(Collider2D other) {
        // Debug.Log("OnTriggerEnter2D");
        if (other.gameObject.tag == "Player") {
            Debug.Log("bag grabbed COLLISION");
            OnBugGrab();
            Destroy(gameObject);
        }
    }
}
