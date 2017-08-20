using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int score;
    Text textEl;
    // Use this for initialization
    void Start () {
        textEl = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {

        textEl.text = "Текущий счет: " + score.ToString();
    }
}
