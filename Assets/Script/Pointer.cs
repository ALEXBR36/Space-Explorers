using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    private Vector3 targetPos; //naming the variables
    private RectTransform pointerRect;

    public void Awake()
    {
        targetPos = new Vector3(-90, 31); //the target position is defined as the volcano pos
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
    }
}
