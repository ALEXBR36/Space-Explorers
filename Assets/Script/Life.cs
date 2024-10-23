using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public static Life instance { get; private set; } //allows other scripts to access an instance of this class. Can only be asinged within this class

    public Image mask;  //allows me to put in the mask in the inspector as it is public
    public float originalSize; //stores original width of mask


    void Awake()
    {
        originalSize = mask.rectTransform.rect.width; //stores og width 
        instance = this; //set the instance to this
    }

    public void SetValue(float value) //adjusts width of mask in relation to the float that is sent from the other scripts
    {
        if (mask.rectTransform != null) //checks if the masks rectTransform is in existence
        {
            mask.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, originalSize * value); //this multiplies the orignial mask size by the new valueand then sets it horizontally with the anchors
            Debug.Log("value is set"); //console
        }
    }
}
