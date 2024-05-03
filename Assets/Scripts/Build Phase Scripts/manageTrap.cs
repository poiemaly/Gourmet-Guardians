using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manageTrap : MonoBehaviour
{
    public GameObject knifeTrap;
    public GameObject panTrap;
    private bool inArea = false;
    // Update is called once per frame
    void Update()
    {
        if (inArea) {
            if(Input.GetKeyDown(KeyCode.E)){
                Debug.Log("E");
                GameObject newObject = Instantiate(knifeTrap, gameObject.transform.position, transform.rotation);
                Debug.Log(gameObject.transform);
            } else if (Input.GetKeyDown(KeyCode.Q)) {
                Debug.Log("Q");
                GameObject newObject = Instantiate(knifeTrap, gameObject.transform.position, transform.rotation);
                Debug.Log(gameObject.transform);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")) {
            inArea = true;
        }
    }
    private void OnTriggerExit() {
        if (inArea) {
            inArea = false;
        }
    }
}