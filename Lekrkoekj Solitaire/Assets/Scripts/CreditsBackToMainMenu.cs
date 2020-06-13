using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsBackToMainMenu : MonoBehaviour
{
    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ToCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
