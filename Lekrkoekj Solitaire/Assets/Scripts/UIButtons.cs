using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIButtons : MonoBehaviour
{
    public GameObject highScorePanel;
    public Button resetButton;

    // Start is called before the first frame update
    void Start()
    {
        if(Solitaire.drawMode == 0)
        {
            resetButton.interactable = false;
        }
        else
        {
            resetButton.interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Solitaire.drawMode = 0;
    }

    public void PlayAgain()
    {
        highScorePanel.SetActive(false);
        Solitaire.drawMode = 0;
        SceneManager.LoadScene("SolitaireGame");
    }
    void ClearTopValues()
    {
        Selectable[] selectables = FindObjectsOfType<Selectable>();
        foreach (Selectable selectable in selectables)
        {
            if (selectable.CompareTag("Top"))
            {
                selectable.suit = null;
                selectable.value = 0;
            }
        }
    }

}
