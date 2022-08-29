/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    delegate void SimpleMessage();
    SimpleMessage simpleMessage;
    void Start()
    {
        simpleMessage = SendConsoleMessage;
        simpleMessage?.Invoke();
    }

    private void SendConsoleMessage()
    {
        Debug.Log("Mensaje Enviado a consola");
    }

}
*/
using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public delegate void PlayerDeath();
    public static event PlayerDeath OnPlayerDeath;

    public GameObject GameOverScreen;
    public static Action OnUpadeScore;

    private void OnEnable()
    {
        OnUpadeScore += UpdateScoreUI;
    }
    private void Awake()
    {
        GameOverScreen.SetActive(false);
        OnPlayerDeath += ShowGameOverScreen;
    }

    private void ShowGameOverScreen()
    {
        GameOverScreen.SetActive(true);
    }

    public void PlayerKilled()
    {
        OnPlayerDeath?.Invoke();
    }

    public void UpdateScoreUI()
    {
        //Cambiar el valor del score en la UI
        Debug.Log("Score actualizado ");
    }
}