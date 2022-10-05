using UnityEngine;
using UnityEngine.UI;

public class ButtonBackInMainMenu : MonoBehaviour
{
    public GameObject PanelMainMenu;
    public GameObject PanelAboutTheAutors;

    public void OnButtonClick()
    {
        PanelMainMenu.SetActive(true);
        PanelAboutTheAutors.SetActive(false);
    }
}
