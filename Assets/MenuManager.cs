using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highScoreMenuText;
    [SerializeField] TMP_InputField uiNameInput;

    // Start is called before the first frame update
    void Start()
    {
        highScoreMenuText.text = $"Best overall Highscor from {GameManager.Instance.bestPlayerName}: {GameManager.Instance.bestPlayerScore}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        GameManager.Instance.StartGame(uiNameInput.text);
    }
}
