using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [Header("Screens")]
    [SerializeField] private GameObject _menuScreen;
    [SerializeField] private GameObject _gameScreen;

    [Header("Buttons")]
    [SerializeField] private Button _openMenuButton;
    [SerializeField] private Button _continueButton;
    [SerializeField] private Button _restartButton; 
    [SerializeField] private Button _quitGame;

    [Header("Text")]
    [SerializeField] private TextMeshProUGUI _text; 
    [Header("Other")]
    [SerializeField] private EventController _eventController;
    private int _cubesArrived = 0;
    // Start is called before the first frame update
    void Start()
    {
        _openMenuButton.onClick.AddListener(SwapScreens);
        _continueButton.onClick.AddListener(SwapScreens);
        _restartButton.onClick.AddListener(Restart);
        _quitGame.onClick.AddListener(QuitGame);
        _eventController.OnCubeArriveAtDestination += CheckIfAllCubesArrives;
    }

    private void OnDestroy()
    {
        _openMenuButton.onClick.RemoveAllListeners();
        _continueButton.onClick.RemoveAllListeners();
        _restartButton.onClick.RemoveAllListeners();
        _quitGame.onClick.RemoveAllListeners();
    }

    private void SwapScreens()
    {
        _menuScreen.SetActive(!_menuScreen.activeSelf);
        _gameScreen.SetActive(!_gameScreen.activeSelf);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void QuitGame()
    {
        Application.Quit();
    }

    private void CheckIfAllCubesArrives()
    {
        _cubesArrived++;
        if (_cubesArrived == 2)
        {
            _continueButton.gameObject.SetActive(false);
            _text.text = "Все кубики достигли цели";
            SwapScreens();
        }
    }
}
