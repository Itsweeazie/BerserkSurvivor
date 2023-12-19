using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject playerAttack;
    public int nbAttack = 0;
    private Vector3 previousPosition;
    private float totalDistance = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // Initialisation de la position précédente au début du jeu
        previousPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Assuming you want to spawn the attack when a key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerAttacking();
            Debug.Log("Total Distance: " + totalDistance);
        }
    }

    public void PlayerAttacking()
    {
        // Calcul de la distance parcourue lors de cette attaque
        float distanceThisAttack = Vector3.Distance(transform.position, previousPosition);

        // Ajout de la distance à la distance totale
        totalDistance += distanceThisAttack;

        // Mise à jour de la position précédente
        previousPosition = transform.position;

        // Check if the player is moving up, down, left, or right and spawn the attack accordingly
        if (Input.GetAxis("Vertical") > 0)
        {
            Debug.Log("Player is moving up");
            SpawnSquareAhead();
            nbAttack += 1;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            Debug.Log("Player is moving down");
            SpawnSquareBehind();
            nbAttack += 1;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            Debug.Log("Player is moving to right");
            SpawnSquareToRight();
            nbAttack += 1;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            Debug.Log("Player is moving to left");
            SpawnSquareToLeft();
            nbAttack += 1;
        }
    }

    private void SpawnSquareAhead()
    {
        // Calculate position ahead of the player
        Vector3 spawnPosition = transform.position + transform.up * 2f; // Adjust 2f as needed

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
        Vector3 spawnPosition = transform.position - transform.up * 2f; // Adjust 2f as needed

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
        Vector3 spawnPosition = transform.position - transform.right * 2f; // Adjust 2f as needed

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
        Vector3 spawnPosition = transform.position + transform.right * 2f; // Adjust 2f as needed

        // Debug the positions
        Debug.Log("Player Position: " + transform.position);
        Debug.Log("Player Direction: " + transform.up);
        Debug.Log("Attack Spawn Position: " + spawnPosition);

        // Instantiate the square at the calculated position
        Instantiate(playerAttack, spawnPosition, Quaternion.identity);
    }
}
