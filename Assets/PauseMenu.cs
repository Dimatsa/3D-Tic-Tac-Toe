
using UnityEngine;


public class PauseMenu : MonoBehaviour {

    public GameObject piecesSelect;
    public GameObject pauseMenu;

    public void DeactivatePanel()
    {
        piecesSelect.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void BackToGame()
    {
        piecesSelect.SetActive(true);
        pauseMenu.SetActive(false);
    }
}
