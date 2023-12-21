using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuFunction : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject control;
    [SerializeField] private GameObject waiting;

    [SerializeField] private AudioSource menuMusic;

    [SerializeField] private Button StartButton;
    [SerializeField] private Button ControlButton;
    [SerializeField] private Button ControlOptionButton;
    [SerializeField] private Button QuitButton;

    void Start()
    {
        StartButton.onClick.AddListener(StartGame);
        ControlButton.onClick.AddListener(EnableOption);
        ControlOptionButton.onClick.AddListener(EnableMenu);
        QuitButton.onClick.AddListener(QuitGame);

        menuMusic = GetComponent<AudioSource>();
        menuMusic.Play();
    }

    public void StartGame()
    {
        mainMenu.SetActive(false);
        waiting.SetActive(true);
        SceneManager.LoadScene("Lucas Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void EnableOption()
    {
        mainMenu.SetActive(false);
        control.SetActive(true);
    }

    public void EnableMenu()
    {
        mainMenu.SetActive(true);
        control.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
