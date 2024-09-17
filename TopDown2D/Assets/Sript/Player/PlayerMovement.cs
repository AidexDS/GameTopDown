using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{


 

    [SerializeField] private float _moveSpeed = 5f;
    
    private Vector2 _movement;
    private  Rigidbody2D _rb;
    private Animator _animator;

    private const string _horizontal = "Horizontal";
    private const string _vertical = "Vertikal";
    private const string _lastHori = "LastHorizontal";
    private const string _lastVerti = "LastVertical";
    

    
    // Start is called before the first frame update
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();

          
        
    }

    // Update is called once per frame
    void Update()
    {
        

        _movement.Set(InputManager.Movement.x, InputManager.Movement.y);

      _rb.velocity = _movement * _moveSpeed*10; 
     
      _animator.SetFloat(_horizontal, _movement.x);
      _animator.SetFloat(_vertical, _movement.y);


//idle direction
      if(_movement != Vector2.zero){
        _animator.SetFloat(_lastHori, _movement.x);
        _animator.SetFloat(_lastVerti, _movement.y);
      }

    }
    
}
