﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour
{
    public TextMesh Text;
    public ParticleSystem SparksParticles;

    private List<string> TextToDisplay = new List<string>();

    private float RotatingSpeed;
    private float TimeToNextText = 0;

    private int CurrentText;

    // Start is called before the first frame update
    void Start()
    {
        TimeToNextText = 0.0f;
        CurrentText = 0;

        RotatingSpeed = 1.0f;

        TextToDisplay.Add("Congratulation");
        TextToDisplay.Add("All Errors Fixed");

        Text.text = TextToDisplay[0];

        SparksParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        TimeToNextText += Time.deltaTime;
        transform.Rotate(Vector3.up * RotatingSpeed * Time.deltaTime, Space.World);
        if (TimeToNextText > 1.5f)
        {
            TimeToNextText = 0.0f;

            Text.text = TextToDisplay[CurrentText++];
            if (CurrentText >= TextToDisplay.Count)
            {
                CurrentText = 0;
            }
        }
    }
}