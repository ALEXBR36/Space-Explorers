using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SpacemanVenus : MonoBehaviour
{
    public int health { get { return currentFlame; } }
    public static int currentFlame;
    public int maxFlame = 5;

    //public int health { get { return currentLife; } }
    public static int currentLife;
    public int maxLife = 50;

    Rigidbody2D rigidbody2d;
    Animator animator;

    public float currentSpeed;

    public float speed = 3.0f;

    Vector2 lookDirection = new Vector2(1, 1);

    float horizontal;
    float vertical;

    public string SceneNamed;

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

        currentFlame = 2;
        FIRE.instance.SetValue(currentFlame / (float)maxFlame);

        currentLife = 50;
        Life.instance.SetValue(currentLife / (float)maxLife);
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
    public void Damage(int amount)
    {
        currentFlame = Mathf.Clamp(currentFlame + amount, 0, maxFlame);

        FIRE.instance.SetValue(currentFlame / (float)maxFlame);
        Debug.Log("Current Flame: " + currentFlame);
    }
    public void LifeDamage(int amount)
    {
        currentLife = Mathf.Clamp(currentLife + amount, 0, maxLife);

        Life.instance.SetValue(currentLife / (float)maxLife);
        Debug.Log("Current Life: " + currentLife);
    }
}
