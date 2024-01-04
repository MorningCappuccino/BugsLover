using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugBullet : MonoBehaviour
{
    private Rigidbody2D _rb;

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
        
    }
}
