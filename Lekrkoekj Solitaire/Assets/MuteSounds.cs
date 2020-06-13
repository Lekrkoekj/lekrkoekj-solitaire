using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.UIElements;

public class MuteSounds : MonoBehaviour
{
    public static int muted;

    void Start()
    {
        muted = PlayerPrefs.GetInt("Muted");
    }

    // Update is called once per frame
    void Update()
    {
        if(muted == 0)
        {
            this.gameObject.GetComponent<AudioSource>().mute = false;
        }
        if (muted == 1)
        {
            this.gameObject.GetComponent<AudioSource>().mute = true;
        }
    }
}
