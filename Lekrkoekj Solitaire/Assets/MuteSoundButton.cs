using UnityEngine;
using UnityEngine.UI;

public class MuteSoundButton : MonoBehaviour
{
    public Image muteButton;
    public Color red;
    public Color white;

    public void ToggleMute()
    {
        if (MuteSounds.muted == 0)
        {
            MuteSounds.muted = 1;
            PlayerPrefs.SetInt("Muted", MuteSounds.muted);
            Debug.Log(MuteSounds.muted);
            return;
        }
        if (MuteSounds.muted == 1)
        {
            MuteSounds.muted = 0;
            PlayerPrefs.SetInt("Muted", MuteSounds.muted);
            Debug.Log(MuteSounds.muted);
            return;
        }
    }

    void Update()
    {
        if (MuteSounds.muted == 0)
        {
            muteButton.color = white;
        }
        if (MuteSounds.muted == 1)
        {
            muteButton.color = red;
        }
    }
}
