using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpacemanVenus : MonoBehaviour
{


    Rigidbody2D rigidbody2d;
    Animator animator;

    public float currentSpeed;

    public float speed = 3.0f;

    Vector2 lookDirection = new Vector2(1, 1);

    float horizontal;
    float vertical;

    public static bool paused;
    public GameObject PauseMenu;
    public GameObject canvas;

    [SerializeField] private InputActionReference moveActionToUse;
    [SerializeField] private float movespeed;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        //pauseMenu();


        Vector2 moveDirection = moveActionToUse.action.ReadValue<Vector2>();

        transform.Translate(moveDirection * speed * Time.deltaTime);
        //Debug.Log(moveDirection.x + " " + moveDirection.y);

        animator.SetFloat("Look Y", moveDirection.x);
        animator.SetFloat("Look X", moveDirection.y);


        //RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 2.5f, LayerMask.GetMask("Karen"));
        //if (hit.collider != null)
        {
            //KarenVenus character = hit.collider.GetComponent<KarenVenus>();

            //if (character != null)
            {
                //character.DialogueRandomiser();
            }
        }






    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);


    }
    public void pause()
    {
        pauseMenu();
    }
    public void pauseMenu()
    {
        {

            if (PauseMenu.activeInHierarchy == true)
            {
                //comes here if the game is already paused
                canvas.SetActive(true);
                PauseMenu.SetActive(false);
                paused = false;
                speed = 3f;
            }
            else
            {
                //comes here if the game is NOT paused
                canvas.SetActive(false);
                PauseMenu.SetActive(true);
                paused = true;
                speed = 0f;
            }
        }

    }
}
