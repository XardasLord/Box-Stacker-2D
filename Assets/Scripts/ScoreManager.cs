using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    public int score = 0;

    void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(10, 10, 100, 50), "Score: " + score);
    }
}
