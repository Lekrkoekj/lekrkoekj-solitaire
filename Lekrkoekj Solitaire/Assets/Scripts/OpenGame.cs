using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void QuickGame()
    {
        SceneManager.LoadScene("SolitaireGame");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
