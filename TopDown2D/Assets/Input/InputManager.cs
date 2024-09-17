using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

public class InputManager : MonoBehaviour
{
    public static Vector2 Movement;

    private PlayerInput _playerInput;
    private InputAction _moveAction;
   
   private void Awake() {

    _playerInput = GetComponent<PlayerInput>();
    
    _moveAction = _playerInput.actions["Move"];
   }

   private void Update(){
     Movement = _moveAction.ReadValue<Vector2>();
   }


}
