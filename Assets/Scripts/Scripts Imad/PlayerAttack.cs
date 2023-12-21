using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerAttack : MonoBehaviour
{
    public GameObject playerAttack;

    private int compteur = 0;
    private bool attack = false;

    private float distanceSpawnAttack = 1.2f;

    private int nbAttack = 0;
    private Vector3 previousPosition;
    private float totalDistance = 0f;

    // Chemin du fichier CSV
    private string csvFilePath = "Assets/OutputDataImad/player_data.csv";

    // Start is called before the first frame update
    void Start()
    {
        // Initialisation de la position précédente au début du jeu
        previousPosition = transform.position;

        // Création ou réinitialisation du fichier CSV
        InitializeCSV();

        // Démarre l'attaque répétée avec le délai spécifié
    }

    void Update(){
        PlayerAttacking();
        compteur = 0;
    }

    public void PlayerAttacking()
    {
        // Calcul de la distance parcourue lors de cette attaque
        float distanceThisAttack = Vector3.Distance(transform.position, previousPosition);

        // Ajout de la distance à la distance totale
        totalDistance += distanceThisAttack;

        // Mise à jour de la position précédente
        previousPosition = transform.position;

        // Enregistrement des données dans le fichier CSV

        // Check if the player is moving up, down, left, or right and spawn the attack accordingly
        if (Input.GetAxis("Vertical") > 0)
        {
            compteur += 1;
            if(compteur == 1){
            Debug.Log("Player is moving up");
            SpawnSquareAhead();
            nbAttack += 1;
            WriteToCSV();
            }
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            compteur += 1;
            if(compteur == 1){
            Debug.Log("Player is moving down");
            SpawnSquareBehind();
            nbAttack += 1;
            WriteToCSV();
            }
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            compteur += 1;
            if(compteur == 1){
            Debug.Log("Player is moving to right");
            SpawnSquareToRight();
            nbAttack += 1;
            WriteToCSV();
            }

        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            compteur += 1;
            if(compteur == 1){
            Debug.Log("Player is moving to left");
            SpawnSquareToLeft();
            nbAttack += 1;
            WriteToCSV();
            }
        }
    }

    private void SpawnSquareAhead()
    {
        // Calculate position ahead of the player
        Vector3 spawnPosition = transform.position + transform.up * distanceSpawnAttack;

        // Debug the positions
        Debug.Log("Player Position: " + transform.position);
        Debug.Log("Player Direction: " + transform.up);
        Debug.Log("Attack Spawn Position: " + spawnPosition);

        // Instantiate the square at the calculated position
        Instantiate(playerAttack, spawnPosition, Quaternion.identity);
    }

    private void SpawnSquareBehind()
    {
        // Calculate position behind the player
        Vector3 spawnPosition = transform.position - transform.up * distanceSpawnAttack;

        // Debug the positions
        Debug.Log("Player Position: " + transform.position);
        Debug.Log("Player Direction: " + transform.up);
        Debug.Log("Attack Spawn Position: " + spawnPosition);

        // Instantiate the square at the calculated position
        Instantiate(playerAttack, spawnPosition, Quaternion.identity);
    }

    private void SpawnSquareToLeft()
    {
        // Calculate position to the left of the player
        Vector3 spawnPosition = transform.position - transform.right * distanceSpawnAttack;

        // Debug the positions
        Debug.Log("Player Position: " + transform.position);
        Debug.Log("Player Direction: " + transform.up);
        Debug.Log("Attack Spawn Position: " + spawnPosition);

        // Instantiate the square at the calculated position
        Instantiate(playerAttack, spawnPosition, Quaternion.identity);
    }

    private void SpawnSquareToRight()
    {
        // Calculate position to the right of the player
        Vector3 spawnPosition = transform.position + transform.right * distanceSpawnAttack;

        // Debug the positions
        Debug.Log("Player Position: " + transform.position);
        Debug.Log("Player Direction: " + transform.up);
        Debug.Log("Attack Spawn Position: " + spawnPosition);

        // Instantiate the square at the calculated position
        Instantiate(playerAttack, spawnPosition, Quaternion.identity);
    }

    // Crée ou réinitialise le fichier CSV
    private void InitializeCSV()
    {
        // Création ou réécriture du fichier
        using (StreamWriter writer = new StreamWriter(csvFilePath, false))
        {
            // Écriture de l'en-tête du fichier CSV
            writer.WriteLine("Timestamp,Attack Number,Total Distance");
        }
    }

    // Enregistre les données actuelles dans le fichier CSV
    private void WriteToCSV()
    {
        // Conversion de totalDistance en chaîne avec un point au lieu d'une virgule
        string totalDistanceString = totalDistance.ToString().Replace(',', '.');

        DateTime timestamp = DateTime.Now;

        // Ajout de la ligne de données au fichier
        using (StreamWriter writer = new StreamWriter(csvFilePath, true))
        {
            writer.WriteLine($"{timestamp},{nbAttack},{totalDistanceString}");
        }
    }
}
