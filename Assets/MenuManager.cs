using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
 


public class MenuManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highScoreMenuText;
    [SerializeField] TMP_InputField uiNameInput;

    // Start is called before the first frame update
    void Start()
    {
        highScoreMenuText.text = $"Best overall Highscore from {GameManager.Instance.bestPlayerName}: {GameManager.Instance.bestPlayerScore}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        GameManager.Instance.StartGame(uiNameInput.text);
    }

    public void Exit()
    {
        
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif


    }
}
