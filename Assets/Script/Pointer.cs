using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pointer : MonoBehaviour
{
    [SerializeField] private Camera UICamera;

    private Vector3 targetPos; //naming the variables
    private RectTransform pointerRect;

    
    public void Awake()
    {
        targetPos = new Vector3(-30, 18); //the target position is defined as the volcano pos
        pointerRect = transform.Find("arrow").GetComponent<RectTransform>(); //referncing the pointer's positon
        Debug.Log("rect");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 toPosition = targetPos; //defining the target pos as the toPos
        Vector3 fromPosition = Camera.main.transform.position; //saying the og pos is where the camera is
        fromPosition.z  = 0f; //making z cord 0, x,y plane
        Vector3 dir = (toPosition - fromPosition).normalized; //calculates the direction by minusing the from from to. Normalized means it makes a number with a length of 1

        float angle = (Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg); //Mathf.Atan2 takes x and y and makes a radian, Rad2Deg just makes it in degrees
        if (angle < 0) //checks if negative
            angle += 360; //if so plus 360

        pointerRect.localEulerAngles = new Vector3(0, 0, angle); //sets pointer to face angle

        float borderSize = 100f; //setting a border
        Vector3 targetPositionScreenPoint = Camera.main.WorldToScreenPoint(targetPos); //converts target to a screen point
        bool offScreen = targetPositionScreenPoint.x <= borderSize || targetPositionScreenPoint.x >= Screen.width - borderSize|| targetPositionScreenPoint.y <= borderSize || targetPositionScreenPoint.y >= Screen.height -borderSize - borderSize; //basically just checks weather the target is off screen, and in relation to border

        if (offScreen) //checks if pointer is offscreen
        {
            Vector3 cappedPos = targetPositionScreenPoint; //create copy
            if (cappedPos.x <= borderSize) cappedPos.x = borderSize; //if pointer is less or equal to zero, puts it on left
            if (cappedPos.x >= Screen.width - borderSize) cappedPos.x = Screen.width - borderSize; //if greater than width puts it on right
            if (cappedPos.y <= borderSize) cappedPos.y = borderSize; //if less or equal to zero set to top
            if (cappedPos.y >= Screen.width - borderSize) cappedPos.y = Screen.height - borderSize; //if greater than screen height, set to bottom

            Vector3 pointerWorldPosition = UICamera.ScreenToWorldPoint(cappedPos); //converts into world position
            pointerRect.position = pointerWorldPosition; //moves pointer to calculated position
            pointerRect.localPosition = new Vector3(pointerRect.localPosition.x, pointerRect.localPosition.y, 0f); //ensures z is zero so it stays on x,y

        }
    }
}
