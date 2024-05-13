using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputField : MonoBehaviour
{
    public Text playerNameInput;

    public static string playerName;
    private bool isEnoughLongName = false;
    internal string text;

    void InputName()
    {
        playerName = playerNameInput.text;
        PlayerPrefs.SetString("PlayerName", playerName);
    }

    void CheckValidName()
    {
        InputName();
        if(1 < playerName.Length && playerName.Length < 11)
        {
            isEnoughLongName = true;
        }
    }

    public void OnClickChangeToGameScene()
    {
        CheckValidName();
        if (isEnoughLongName)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
