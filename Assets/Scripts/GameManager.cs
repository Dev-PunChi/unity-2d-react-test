using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [DllImport ("__Internal")]
    private static extern void CallReact(string userName, int score);

    private int score = 0;

    public TextMeshProUGUI sampleText;

    public int Score
    {
        get => score;
        set
        {
            score = value;
            sampleText.text = score.ToString();
            Debug.Log(score);
        }
    }

    public void UnityCall()
    {
#if UNITY_WEBGL == true && UNITY_EDITOR == false
        CallReact("푼치야!", Score);
#endif
    }

    public void BtnClick()
    {
        Score++;
        UnityCall();
    }
}