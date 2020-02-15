﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour {

    public bool hasLost = false;

	void OnTriggerEnter2D()
    {
        hasLost = true;
    }

    void OnGUI()
    {
        if (hasLost)
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), "GAME OVER!");
            if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25 + 55, 100, 50), "Restart"))
                SceneManager.LoadScene(0);
        }
    }
}
