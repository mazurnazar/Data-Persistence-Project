using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;
using System.IO;
public class MenuUI : MonoBehaviour
{
    public InputField inputField;
    public Text BestScoreText;

 

    
    private void Start()
    {
        BestScoreText.text = "Best Score: " + MenuManager.Instance.playerName + " " + MenuManager.Instance.highScore;
    }
    public void StartGame()
    {
        if(inputField.text == "")
        {
            inputField.placeholder.GetComponent<Text>().text = "Enter again";
            inputField.placeholder.color = Color.red;
            return;
        }
        MenuManager.Instance.playerName = inputField.text;
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }    
}
