using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : TeddyElement
{
    public static PlayerView Instance;
    
    private float _speed;

    private Rigidbody2D _rigidBody;
    private Animator _animator;

    private Vector2 _moveAmount;
    
    
    private static readonly int IsRunning = Animator.StringToHash("IsRunning");

    private void Awake()
    {
        Instance = this;
        _speed = App.model.PlayerSpeed;
    }

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        _rigidBody.MovePosition(_rigidBody.position + _moveAmount * Time.fixedDeltaTime);
    }

    public void Move(Vector2 moveInput)
    {
        _moveAmount = moveInput.normalized * _speed;
        if (_moveAmount != Vector2.zero)
        {
            _animator.SetBool(IsRunning, true);
        }
        else
        {
            _animator.SetBool(IsRunning, false);
        }
    }
}
