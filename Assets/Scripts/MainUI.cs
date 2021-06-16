using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using TMPro;

public class MainUI : MonoBehaviour
{
    public static string playerName;
    [SerializeField] private TMP_InputField nameField;
    [SerializeField] private TMP_Text highScoreField;

    // Start is called before the first frame update
    void Start()
    {
        MainManager.LoadPoints();
        highScoreField.text = $"Highest Score {MainManager.bestScore}, belongs to {MainManager.topPlayerName}";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NameChange()
    {
        playerName = nameField.text;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }
}
