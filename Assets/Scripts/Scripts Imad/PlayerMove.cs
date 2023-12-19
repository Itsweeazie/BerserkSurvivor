using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float vitesseDeplacement = 5f;

    void Update()
    {
        PlayerMovements();
    }

    public void PlayerMovements(){
        // Déplacement vers le haut
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(Vector2.up * vitesseDeplacement * Time.deltaTime);
        }

        // Déplacement vers la droite
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * vitesseDeplacement * Time.deltaTime);
        }

        // Déplacement vers le bas
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * vitesseDeplacement * Time.deltaTime);
        }

        // Déplacement vers la gauche
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector2.left * vitesseDeplacement * Time.deltaTime);
        }
    }
}