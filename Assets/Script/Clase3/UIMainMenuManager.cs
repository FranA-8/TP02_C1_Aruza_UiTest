using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMainMenuManager : MonoBehaviour
{
    [SerializeField] Button btnPlay;

    private void Awake()
    {
        btnPlay.onClick.AddListener(OnPlayButtonClicked);

    }
    
    private void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("Gameplay");
    }
    
    private void OnDestroy()
    {
        btnPlay.onClick.RemoveListener(OnPlayButtonClicked);
    }   
}
