using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject gameoverMenu;

    [SerializeField] private AudioSource gameMusic;
    //[SerializeField] private AudioSource goMusic;

    [SerializeField] private Button menuButton;
    [SerializeField] private Button deathButton;

    void Start()
    {
        menuButton.onClick.AddListener(returnMenu);
        deathButton.onClick.AddListener(gOMenu);

        //goMusic = GetComponent<AudioSource>();
        gameMusic = GetComponent<AudioSource>();
        gameMusic.Play();
    }

    public void returnMenu()
    {
        SceneManager.LoadScene("Lucas Game");
    }

    public void gOMenu()
    {
        SceneManager.LoadScene("Lucas GO");

        /*gameoverMenu.SetActive(true);
        gameMusic.Stop();
        goMusic.Play();*/
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
