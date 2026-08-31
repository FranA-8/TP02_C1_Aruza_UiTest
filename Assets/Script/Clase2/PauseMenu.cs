using System;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class CreditsMenu : MonoBehaviour
{
    [SerializeField] private Movement player1;
    [SerializeField] private Movement player2;
    [SerializeField] private Button btnSettingsPause;
    [SerializeField] private Button btnExitPause;
    [SerializeField] private Button btnCreditsPause;
    [SerializeField] private Button btnBackPause;
    [SerializeField] private Button btnBackCreditsPause;
    [SerializeField] private Button btnContinue;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject pauseSettingsMenu;
    [SerializeField] private GameObject pauseCreditsMenu;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private Slider sliderPlayer1SpeedPause;
    [SerializeField] private Slider sliderPlayer2SpeedPause;
    [SerializeField] private TMP_Text p1SpeedTextPause;
    [SerializeField] private TMP_Text p2SpeedTextPause;
    private void Awake()
    {
        btnSettingsPause.onClick.AddListener(OnSettingsPauseClicked);
        btnExitPause.onClick.AddListener(OnExitPauseClicked);
        btnCreditsPause.onClick.AddListener(OnCreditsPauseClicked);
        btnBackPause.onClick.AddListener(OnBackPauseClicked);
        btnBackCreditsPause.onClick.AddListener(OnBackCreditsPauseClicked);
        sliderPlayer1SpeedPause.onValueChanged.AddListener(OnPlayer1SpeedChangedPause);
        sliderPlayer2SpeedPause.onValueChanged.AddListener(OnPlayer2SpeedChangedPause);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnDestroy()
    {
        btnSettingsPause.onClick.RemoveAllListeners();
        btnExitPause.onClick.RemoveAllListeners();
        btnCreditsPause.onClick.RemoveAllListeners();
        btnBackPause.onClick.RemoveAllListeners();
        btnBackCreditsPause.onClick.RemoveAllListeners();
        btnContinue.onClick.RemoveAllListeners();
        sliderPlayer1SpeedPause.onValueChanged.RemoveAllListeners();
        sliderPlayer2SpeedPause.onValueChanged.RemoveAllListeners();
    }
    private void OnSettingsPauseClicked()
    {
        pauseMenu.SetActive(false);
        pauseSettingsMenu.SetActive(true);
    }
    private void OnExitPauseClicked()
    {
        pauseMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
    private void OnCreditsPauseClicked()
    {
        pauseMenu.SetActive(false);
        pauseCreditsMenu.SetActive(true);
    }
    private void OnBackPauseClicked()
    {
        pauseSettingsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
    private void OnBackCreditsPauseClicked()
    {
        pauseCreditsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
    private void OnPlayer1SpeedChangedPause(float value)
    {
        player1.moveSpeed = value;
        p1SpeedTextPause.text = value.ToString("F2");
    }
    private void OnPlayer2SpeedChangedPause(float value)
    {
        player2.moveSpeed = value;
        p2SpeedTextPause.text = value.ToString("F2");
    }
}
