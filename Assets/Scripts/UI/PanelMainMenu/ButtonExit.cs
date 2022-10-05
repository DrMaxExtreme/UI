using UnityEngine;
using UnityEngine.UI;

public class ButtonExit : MonoBehaviour
{
    public void OnButtonClick()
    {
        Debug.Log("Exit");

        Application.Quit();
    }
}
