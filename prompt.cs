using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Text1;
    public string EachInput;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Enter)) {
            Text1.SetActive(true);
            EachInput = Inpu
            if (Input.GetKeyDown(KeyCode.1)) {
                
            }
            else if (Input.GetKeyDown(KeyCode.2)) {

            }
            else if (Input.GetKeyDown(KeyCode.3)) {
            
            }
            else {
                Text1.SetActive(false);
            }
        }
        
    }
}