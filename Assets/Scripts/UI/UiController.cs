using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField] private GameObject _menuScreen;
    [SerializeField] private GameObject _gameScreen;

    [SerializeField] private Button _openMenuButton;
    [SerializeField] private Button _continueButton;

    [SerializeField] private Button _quitGame;
    // Start is called before the first frame update
    void Start()
    {
        _openMenuButton.onClick.AddListener(SwapScreens);
        _continueButton.onClick.AddListener(SwapScreens);
        _quitGame.onClick.AddListener(QuitGame);
    }

    private void OnDestroy()
    {
        _openMenuButton.onClick.RemoveAllListeners();
        _continueButton.onClick.RemoveAllListeners();
        _quitGame.onClick.RemoveAllListeners();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwapScreens()
    {
        _menuScreen.SetActive(!_menuScreen.activeSelf);
        _gameScreen.SetActive(!_gameScreen.activeSelf);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
