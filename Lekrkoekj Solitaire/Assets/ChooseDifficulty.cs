using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseDifficulty : MonoBehaviour
{
    public GameObject difficultyPanel;

    void Start()
    {
        Time.timeScale = 0;
        difficultyPanel.SetActive(true);
        if (Solitaire.drawMode == 1 || Solitaire.drawMode == 3)
        {
            difficultyPanel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void SelectEasy()
    {
        Solitaire.drawMode = 1;
        Time.timeScale = 1;
        difficultyPanel.SetActive(false);
        SceneManager.LoadScene("SolitaireGame");
    }
    public void SelectHard()
    {
        Solitaire.drawMode = 3;
        Time.timeScale = 1;
        difficultyPanel.SetActive(false);
        SceneManager.LoadScene("SolitaireGame");
    }
}
