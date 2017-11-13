﻿using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

    int min = 1;
    int max = 1000;
    int startGuess;
    int guess;

	// Use this for initialization
	void Start () {
        max +=1 ;
        startGuess = max / 2;

        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me!");
        print("The highest number you can pick is " +max);
        print("The lowest number you can pick is " + min);
        print("Pick your number now!");
        print(" ");
        print(" ");
        print(" ");
        print("Is your number higher or lower than" + startGuess + " ?");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            print("Higher or lower than " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            print("Higher or lower than " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won");
        }
    }
}
