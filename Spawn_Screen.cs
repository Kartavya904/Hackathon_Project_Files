using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Screen : MonoBehaviour
{
    public GameObject Screen_Prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            
            Vector3 tempSpawnLocation = transform.GetChild(0).position;
            Instantiate(Screen_Prefab, tempSpawnLocation, transform.GetChild(0).rotation);
        }
    }
}
