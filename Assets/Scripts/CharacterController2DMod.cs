using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2DMod : CharacterController2D
{
    public static CharacterController2DMod Instance;

    private float _defaultJumpForce;

    protected override void Awake()
    {
        base.Awake();
        Instance = this;

        _defaultJumpForce = m_JumpForce;
    }

    public float GetDefaultJumpForce() => _defaultJumpForce;

    public float GetJumpForce() => m_JumpForce;

    public void SetJumpForce(float force) {
        m_JumpForce = force;
    }
}
