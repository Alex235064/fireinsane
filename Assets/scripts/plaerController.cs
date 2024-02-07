using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaerController : MonoBehaviour
{
public float Gravity = 9.8f;
    public float JampForce;

    private float _fallVelocity = 1;

    private CharacterController _CharacterController;
    
    // Start is called before the first frame update
    void Start()
    {
        _CharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
        {
          _fallVelocity = -JampForce;
        }
    }
    void FixedUpdate()
    {
       

        _fallVelocity += Gravity * Time.fixedDeltaTime;
        _CharacterController.Move(Vector3.down * _fallVelocity * Time.fixedDeltaTime);
    }

}