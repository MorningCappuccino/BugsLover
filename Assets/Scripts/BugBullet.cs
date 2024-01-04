using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugBullet : MonoBehaviour
{
    private Rigidbody2D _rb;

    public delegate void BugGrabDelegate();
    public static event BugGrabDelegate OnBugGrab;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        PlayerMovement player = FindObjectOfType<PlayerMovement>();

        //why transform.right - won't work?
        if (player != null) _rb.AddForce(player.transform.right * 200f);
    }

    // Update is called once per frame
    void Update()
    {
        //not a bug but a feature (game requirement)
        if (transform.position.y < -10)
        {
            GameManager.Instance.AddScore(50);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            Debug.Log("OnCollisionEnter2D GRAB");
            OnBugGrab();
            Destroy(gameObject);
        }
    }
}
