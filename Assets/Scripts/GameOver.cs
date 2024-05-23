using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
    using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    public Text pointsText;

    public void Setup(int score){
        gameObject.SetActive(true);
        pointsText.text = "Score: " + score.ToString();
    }

    public void Retry()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit2()
    {
        #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

}