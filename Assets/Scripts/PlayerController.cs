using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isAttaking=false;
    public FloatingJoystick joystick;
    public CapsuleCollider playerCollider;
    public float rotationSpeed;
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        playerCollider = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
       if (isAttaking)
        {
            return;
        }

        float moveHorizontal = joystick.Horizontal;
        float moveVertical = joystick.Vertical;




        Vector3 movementDirection= new Vector3(moveHorizontal, 0, moveVertical);
        movementDirection.Normalize();
        //transform.Translate(movementDirection*moveSpeed*Time.deltaTime, Space.World);
        GetComponent<Rigidbody>().MovePosition(transform.position+ movementDirection * moveSpeed * Time.deltaTime);
        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection,Vector3.up);
            transform.rotation=Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed*Time.deltaTime);
        }

    }
}
