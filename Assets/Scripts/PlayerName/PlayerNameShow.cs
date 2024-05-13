using UnityEngine;
using UnityEngine.UI;

public class PlayerNameShow : MonoBehaviour
{
    public Text playerNameText;

    private void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;
    }
}
