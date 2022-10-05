using UnityEngine;
using UnityEngine.UI;

public class ButtonAboutTheAuthors : MonoBehaviour
{
    public GameObject PanelMainMenu;
    public GameObject PanelAboutTheAutors;

    public void OnButtonClick()
    {
        PanelMainMenu.SetActive(false);
        PanelAboutTheAutors.SetActive(true);
    }
}
