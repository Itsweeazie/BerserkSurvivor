using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GMgo : MonoBehaviour
{
    [SerializeField] private GameObject gameoverMenu;

    [SerializeField] private AudioSource goMusic;

    [SerializeField] private Button menuButton;


    // Start is called before the first frame update
    void Start()
    {
        menuButton.onClick.AddListener(returnMenu);

        goMusic = GetComponent<AudioSource>();
        goMusic.Play();
    }

    public void returnMenu()
    {
        SceneManager.LoadScene("Lucas Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
