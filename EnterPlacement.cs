using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ScreenManagement;

public class PlayerMovement : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        if Input.GetKeyDown(KeyCode.Enter) 
        {
            Instantiate(Screen_Prefab, tempSpawnLocation,);
        }
    }
}
