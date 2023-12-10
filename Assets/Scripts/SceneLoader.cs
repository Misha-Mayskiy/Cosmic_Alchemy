using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private int newGameLevel = 1;
    [SerializeField] private int settingsLevel = 1;

    public void NewGameButton() {
        SceneManager.LoadScene(newGameLevel);
    }

    public void SettingsButton() {
        SceneManager.LoadScene(settingsLevel);
    }

    public void ExitButton() {
        Debug.Log("EXIT COMPLETE!");
    }
}
