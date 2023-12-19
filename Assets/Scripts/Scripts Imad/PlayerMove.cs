using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
  
  public int speed = 10;
 
  // Update is called once per frame
  void FixedUpdate () {
    
    float mouveHorizontal = Input.GetAxis("Horizontal");
    float mouveVertical = Input.GetAxis("Vertical");
    
    Vector3 mouvment = new Vector3(mouveHorizontal, 0, mouveVertical);
    GetComponent<Rigidbody>().AddForce(mouvment * speed * Time.deltaTime);
    
  }
}