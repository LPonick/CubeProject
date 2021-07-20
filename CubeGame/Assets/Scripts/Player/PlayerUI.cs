using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 posicaoMouse = Input.mousePosition;
        if(Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log(posicaoMouse);
        }
    }
}
