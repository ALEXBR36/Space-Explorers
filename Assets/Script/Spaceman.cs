using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Spaceman1 : MonoBehaviour


{
    Rigidbody2D rigidbody2d;
    Animator animator;

    public float currentSpeed;

    public float speed = 3.0f;

    Vector2 lookDirection = new Vector2(1, 1);

    float horizontal;
    float vertical;

    [SerializeField] private InputActionReference moveActionToUse;
    [SerializeField] private float movespeed;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {
        


        Debug.Log(currentSpeed + "Speed");

        Vector2 moveDirection = moveActionToUse.action.ReadValue<Vector2>();
  
        transform.Translate(moveDirection * speed * Time.deltaTime);
        Debug.Log(moveDirection.x + " " + moveDirection.y);

        animator.SetFloat("Look Y", moveDirection.x);
        animator.SetFloat("Look X", moveDirection.y);


        





    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);

      
    }

}
