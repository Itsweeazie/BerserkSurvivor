using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GOFunctions : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject gameOver;

    [SerializeField] private AudioSource goMusic;

    [SerializeField] private Button menuButton;

    void Start()
    {
        menuButton.onClick.AddListener(returnMenu);

        goMusic = GetComponent<AudioSource>();
        goMusic.Play();
    }
    public void returnMenu()
    {
        Debug.Log("Hello");
        SceneManager.LoadScene("Lucas UI");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
