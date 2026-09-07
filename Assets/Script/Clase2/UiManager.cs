using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour

{   
    [SerializeField] private Movement player1;
    [SerializeField] private Movement player2;
    [SerializeField] private Button btnPlay;
    [SerializeField] private Button btnSettings;
    [SerializeField] private Button btnExit;
    [SerializeField] private Button btnCredits;
    [SerializeField] private Button btnBack;
    [SerializeField] private Button btnSettingsPause;
    [SerializeField] private Button btnExitPause;
    [SerializeField] private Button btnCreditsPause;
    [SerializeField] private Button btnBackPause;
    [SerializeField] private Button btnBackCreditsPause;
    [SerializeField] private Button btnBackCredits;
    [SerializeField] private Button btnContinue;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject pauseSettingsMenu;
    [SerializeField] private GameObject pauseCreditsMenu;
    [SerializeField] private GameObject settingsMenu;
    [SerializeField] private GameObject creditsMenu;
    [SerializeField] private KeyCode pause = KeyCode.Escape;
    [SerializeField] private Slider sliderPlayer1Speed;
    [SerializeField] private Slider sliderPlayer2Speed;
    [SerializeField] private TMP_Text p1SpeedText;
    [SerializeField] private TMP_Text p2SpeedText;
    private bool isPaused = false;

    private void Awake()
    {
        btnPlay.onClick.AddListener(OnPlayClicked);
        btnSettings.onClick.AddListener(OnSettingsClicked);
        btnExit.onClick.AddListener(OnExitClicked);
        btnCredits.onClick.AddListener(OnCreditsClicked);
        btnBack.onClick.AddListener(OnBackClicked);
        btnBackCredits.onClick.AddListener(OnBackCreditsClicked);
        btnSettingsPause.onClick.AddListener(OnSettingsPauseClicked);
        btnExitPause.onClick.AddListener(OnExitPauseClicked);
        btnCreditsPause.onClick.AddListener(OnCreditsPauseClicked);
        btnBackPause.onClick.AddListener(OnBackPauseClicked);
        btnBackCreditsPause.onClick.AddListener(OnBackCreditsPauseClicked);
        btnContinue.onClick.AddListener(OnContinueClicked);
        sliderPlayer1Speed.onValueChanged.AddListener(OnPlayer1SpeedChanged);
        sliderPlayer2Speed.onValueChanged.AddListener(OnPlayer2SpeedChanged);

    }
    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(pause))
        {
            pauseMenu.SetActive(true);

            isPaused = !isPaused;
            pauseMenu.SetActive(isPaused);
            if (isPaused)
                Time.timeScale = 0;
            else
                Time.timeScale = 1;
        }
    }
    private void OnDestroy()
    {
        btnPlay.onClick.RemoveAllListeners();
        btnSettings.onClick.RemoveAllListeners();
        btnExit.onClick.RemoveAllListeners();
        btnCredits.onClick.RemoveAllListeners();
        btnBack.onClick.RemoveAllListeners();
        btnBackCredits.onClick.RemoveAllListeners();
        btnSettingsPause.onClick.RemoveAllListeners();
        btnExitPause.onClick.RemoveAllListeners();
        btnCreditsPause.onClick.RemoveAllListeners();
        btnBackPause.onClick.RemoveAllListeners();
        btnBackCreditsPause.onClick.RemoveAllListeners();
        btnContinue.onClick.RemoveAllListeners();
        sliderPlayer1Speed.onValueChanged.RemoveAllListeners();
        sliderPlayer2Speed.onValueChanged.RemoveAllListeners();
    }
    private void OnPlayClicked()
    {
        mainMenu.SetActive(false);
        Time.timeScale = 1;
    }
    private void OnExitClicked()
    {
        Application.Quit();

#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif

    }
    private void OnSettingsClicked()
    {
        settingsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }
    private void OnCreditsClicked()
    {
        creditsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }
    private void OnPlayer1SpeedChanged(float value)
    {
        player1.moveSpeed = value;
        p1SpeedText.text = value.ToString("F2");
    }
    private void OnPlayer2SpeedChanged(float value)
    {
        player2.moveSpeed = value;
        p2SpeedText.text = value.ToString("F2");
    }
    private void OnBackClicked()
    {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
    private void OnBackCreditsClicked()
    {
        creditsMenu.SetActive(false);
        mainMenu.SetActive(true);
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
        pauseCreditsMenu.SetActive(true);
        pauseMenu.SetActive(false);
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
    private void OnContinueClicked()
    {
        pauseMenu.SetActive(false);

        isPaused = !isPaused;
        pauseMenu.SetActive(isPaused);
        if (isPaused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }
    
}
