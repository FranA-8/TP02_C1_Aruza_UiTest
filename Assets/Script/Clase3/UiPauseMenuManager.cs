using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiPauseMenuManager : MonoBehaviour
{
    [SerializeField] private PhysicsMovement player1;
    [SerializeField] private PhysicsMovement player2;
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
    [SerializeField] private GameObject pauseMenuPanel;
    [SerializeField] private Slider sliderPlayer1SpeedPause;
    [SerializeField] private Slider sliderPlayer2SpeedPause;
    [SerializeField] private Slider sliderPlayer1ColorPause;
    [SerializeField] private Slider sliderPlayer2ColorPause;
    [SerializeField] private Slider sliderPlayer1HigthPause;
    [SerializeField] private Slider sliderPlayer2HigthPause;
    [SerializeField] private TMP_Text p1SpeedTextPause;
    [SerializeField] private TMP_Text p2SpeedTextPause;
    [SerializeField] private TMP_Text p1ColorTextPause;
    [SerializeField] private TMP_Text p2ColorTextPause;
    [SerializeField] private TMP_Text p1HigthTextPause;
    [SerializeField] private TMP_Text p2HigthTextPause;
    [SerializeField] private KeyCode pause = KeyCode.Escape;
    [SerializeField] private Renderer renderP1;
    [SerializeField] private Renderer renderP2;
    bool isPaused = false;

    private void Awake()
    {
        renderP1 = GetComponent<Renderer>();
        renderP2 = GetComponent<Renderer>();

        btnSettingsPause.onClick.AddListener(OnSettingsPauseClicked);
        btnExitPause.onClick.AddListener(OnExitPauseClicked);
        btnCreditsPause.onClick.AddListener(OnCreditsPauseClicked);
        btnContinue.onClick.AddListener(OnContinueClicked);
        btnBackPause.onClick.AddListener(OnBackPauseClicked);
        btnBackCreditsPause.onClick.AddListener(OnBackCreditsPauseClicked);
        sliderPlayer1SpeedPause.onValueChanged.AddListener(OnPlayer1SpeedChangedPause);
        sliderPlayer2SpeedPause.onValueChanged.AddListener(OnPlayer2SpeedChangedPause);
        sliderPlayer1ColorPause.onValueChanged.AddListener(OnPlayer1ColorChangedPause);
        sliderPlayer2ColorPause.onValueChanged.AddListener(OnPlayer2ColorChangedPause);
        sliderPlayer1HigthPause.onValueChanged.AddListener(OnPlayer1HigthChangedPause);
        sliderPlayer2HigthPause.onValueChanged.AddListener(OnPlayer2HigthChangedPause);
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
        sliderPlayer1ColorPause.onValueChanged.RemoveAllListeners();
        sliderPlayer2ColorPause.onValueChanged.RemoveAllListeners();
        sliderPlayer1HigthPause.onValueChanged.RemoveAllListeners();
        sliderPlayer2HigthPause.onValueChanged.RemoveAllListeners();
    }
    private void OnContinueClicked()
    {
        pauseMenuPanel.SetActive(false);
        isPaused = !isPaused;
        pauseMenuPanel.SetActive(isPaused);
        if (isPaused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }
    private void OnSettingsPauseClicked()
    {
        pauseMenuPanel.SetActive(false);
        pauseSettingsMenu.SetActive(true);
    }
    private void OnExitPauseClicked()
    {
        pauseMenu.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }
    private void OnCreditsPauseClicked()
    {
        pauseMenuPanel.SetActive(false);
        pauseCreditsMenu.SetActive(true);
    }
    private void OnBackPauseClicked()
    {
        pauseSettingsMenu.SetActive(false);
        pauseMenuPanel.SetActive(true);
    }
    private void OnBackCreditsPauseClicked()
    {
        pauseCreditsMenu.SetActive(false);
        pauseMenuPanel.SetActive(true);
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
    private void OnPlayer1ColorChangedPause(float value)
    {
        renderP1.material.color = new Color(Random.value, Random.value, Random.value, 1f);
        p1ColorTextPause.text = value.ToString("F2");
    }
    private void OnPlayer2ColorChangedPause(float value)
    {

        renderP2.material.color = new Color(Random.value, Random.value, Random.value, 1f);
        p2ColorTextPause.text = value.ToString("F2");
    }
    private void OnPlayer1HigthChangedPause(float value)
    {
        player1.transform.localScale = new Vector3(player1.transform.localScale.x, value, player1.transform.localScale.z);
        p1HigthTextPause.text = value.ToString("F2");
    }
    private void OnPlayer2HigthChangedPause(float value)
    {
        player2.transform.localScale = new Vector3(player2.transform.localScale.x, value, player2.transform.localScale.z);
        p2HigthTextPause.text = value.ToString("F2");
    }
    private void Update()
    {
        if (Input.GetKeyDown(pause))
        {
            pauseMenuPanel.SetActive(true);

            isPaused = !isPaused;
            pauseMenuPanel.SetActive(isPaused);
            if (isPaused)
                Time.timeScale = 0;
            else
                Time.timeScale = 1;
        }
    }
}
