using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FIRE : MonoBehaviour
{
    public static FIRE instance { get; private set; }

    public Image mask;
    public float originalSize;

    void Awake()
    {

    }

    public void Start()
    {
        originalSize = mask.rectTransform.rect.width;
        instance = this;
    }

    public void SetValue(float value)
    {
        if (mask.rectTransform != null)
        {
            mask.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, originalSize * value);
            Debug.Log("value is set");
        }
    }
}
