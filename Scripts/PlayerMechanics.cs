using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMechanics : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    public float speed = 5f;
    public Transform Ball;
    public Transform HandPos;
    public Transform Target;

    public bool holdingBall = true;
    public bool readyToShoot;
    float shootTime = 0;
    float shotDuration;
    
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (holdingBall)
        {
            Ball.position = HandPos.position;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            readyToShoot = true;
            holdingBall = false;
            shootTime = 0;
        }
      
            if (readyToShoot)
            {
                shootTime += Time.deltaTime;
                shotDuration = 0.5f;
                float bshoot = shootTime / shotDuration;

                Vector3 A = HandPos.position;
                Vector3 B = Target.position;
                Vector3 pos = Vector3.Lerp(A, B, bshoot);

                Vector3 arc = Vector3.up * 5 * Mathf.Sin(bshoot * 3.14f);
                Ball.position = pos + arc;

                if(bshoot >= 1)
            {
                Ball.GetComponent<Rigidbody>().isKinematic = false;
                readyToShoot = false;
            }
                
            }
        

    }


    //process inputs from input manager script and apply to character controller
    public void MakeMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
    }

  
    
  
}
