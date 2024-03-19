using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreSaver : MonoBehaviour {
    public Text score;
    public Text heightScore;
    
	// Use this for initialization
	void Start () {
        heightScore.text = PlayerPrefs.GetInt("heightscore").ToString();
        score.text = PlayerPrefs.GetInt("score").ToString();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
