using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeAnimator : MonoBehaviour
{
    public Animator animator;
    public Color[] colors; 
    public float transitionDuration = 1.0f; 

    private int currentColorIndex = 0;
    private Color currentColor;
    private float transitionTimer = 3.0f;

    void Start()
    {
        if (animator == null)
            animator = GetComponent<Animator>();

        currentColor = colors[currentColorIndex];
        UpdateColor();
    }

    void Update()
    {
        transitionTimer += Time.deltaTime;

        if (transitionTimer >= transitionDuration)
        {
            currentColorIndex = (currentColorIndex + 1) % colors.Length;
            currentColor = colors[currentColorIndex];
            UpdateColor();
            transitionTimer = 0.0f;
        }
    }

    void UpdateColor()
    {
        GetComponent<Renderer>().material.color = currentColor;
    }
}

