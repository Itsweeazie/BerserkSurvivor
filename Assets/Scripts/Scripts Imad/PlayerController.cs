using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float vitesseDeplacement = 5f;

    void Update()
    {
        PlayerMovements();
    }

    public void PlayerMovements()
    {
        // Déplacement vertical (haut/bas)
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * vitesseDeplacement * Time.deltaTime);

        // Déplacement horizontal (gauche/droite)
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * vitesseDeplacement * Time.deltaTime);
    }

    public void PlayerAttacking(){}
}
