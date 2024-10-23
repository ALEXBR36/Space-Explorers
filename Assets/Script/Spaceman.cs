using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Spaceman1 : MonoBehaviour


{
    //public string[] Dialogue; //array to hold my dialogue strings

    Rigidbody2D rigidbody2d; //refernce to these two components
    Animator animator;

    public float currentSpeed; //current speed of the player

    public float speed = 3.0f; //basic speed of player

    //Vector2 lookDirection = new Vector2(1, 1); //

    float horizontal; //horizontal inputs used in calculations
    float vertical; //vertical input used in calculations

    public int health { get { return currentFlame; } } //gets the flame count
    public static int currentFlame;//static varibale for flame count which is shared between all the instances in which this occurs
    public int maxFlame = 5; //max flame

    public static bool paused; //static bool (true or false) to see if game is paused
    public GameObject PauseMenu; //a way to reference the gameobject in the inspector e.g. drag in the pausemenu into the public slot, and the code picks that up
    public GameObject canvas;//a way to reference the gameobject in the inspector e.g. drag in the canvas into the public slot, and the code picks that up

    [SerializeField] private InputActionReference moveActionToUse;//references the input action for movement
    //[SerializeField] private float movespeed;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>(); //start these components and attatch them to the player
        animator = GetComponent<Animator>();

        paused = false; //set paused bool to false

        currentFlame = 1; //set current flame to one as earth is quite cold compared to other rocky planets
        FIRE.instance.SetValue(currentFlame / (float)maxFlame); //use this float value ti then set the vlaue of the instance in the clas FIRE
        Debug.Log("value is set to 1"); //sends a message to console that the value is one
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveDirection = moveActionToUse.action.ReadValue<Vector2>(); //creates a vector which reads the move input

        transform.Translate(moveDirection * speed * Time.deltaTime); //move the player by its speed, move direction and by time by the last frame
        //Debug.Log(moveDirection.x + " " + moveDirection.y);

        animator.SetFloat("Look Y", moveDirection.x); //update animator to look in a certain direction
        animator.SetFloat("Look X", moveDirection.y);

        //defining a raycast hit as when the raycast of a length of 2.5f collides with an objedct of the layer mask Karen
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 2.5f, LayerMask.GetMask("Karen"));
        if (hit.collider != null) //if something is being hit
        {
            Karen character = hit.collider.GetComponent<Karen>(); //get karen script/component

            if (character != null) //if it is found
            {
                character.DisplayDialogue();//trigger this function

               
            }
        }




    }
    void FixedUpdate() //physics calculations
    {
        Vector2 position = rigidbody2d.position; //gets the current postion of the rigidbody
        position.x = position.x + speed * horizontal * Time.deltaTime; //update x position to the x position plus speed times horizontal times the time since the last frame
        position.y = position.y + speed * vertical * Time.deltaTime;// update y position to the y position plus speed times horizontal times the time since the last frame

        rigidbody2d.MovePosition(position); //move the rigidbody as calculated above

    }

    public void pause() //when button is pressed this code calls the pauseMenu function
    {
        pauseMenu();
    }
    public void pauseMenu()
    {
        {

            if (PauseMenu.activeInHierarchy == true) //if the pause menu is on
            {
                //comes here if the game is already paused
                canvas.SetActive(true); //sets the normal canvas true
                PauseMenu.SetActive(false); //turns off pause menu
                paused = false; //pause to false
                speed = 3f; //allow player to move

            }
            else
            {
                //comes here if the game is NOT paused
                canvas.SetActive(false);  //sets the normal canvas to be inactive and invisible
                PauseMenu.SetActive(true); //turns on pause menu
                paused = true;
                speed = 0f; //prevent player from moving
            }
        }
    }
}
