using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOption : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject control;

    [SerializeField] private Button buttonOption;

    void Start()
    {
        buttonOption.onClick.AddListener(EnableMenu);
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
