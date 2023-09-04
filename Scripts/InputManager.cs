using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.PlayerMoveActions playerMove;

    private PlayerMechanics mechanics;

    
    
    
    // Start is called before the first frame update
    void Awake()
    {
        playerInput = new PlayerInput();
        playerMove = playerInput.PlayerMove;
        mechanics = GetComponent<PlayerMechanics>();

       
      

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mechanics.MakeMove(playerMove.Movement.ReadValue<Vector2>());
 
        
    }

    private void OnEnable()
    {
        playerMove.Enable();
    }

    private void OnDisable()
    {
        playerMove.Disable();
    }

}
