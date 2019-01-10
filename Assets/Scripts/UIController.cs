﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

    public GameObject lossScreen;

	// Use this for initialization
	void Start ()
    {
        lossScreen.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (lossScreen.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("main");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}

    public void loss()
    {
        lossScreen.SetActive(true);
        Time.timeScale = 0;
    }
}