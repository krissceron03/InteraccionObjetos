using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class jugador : MonoBehaviour
{
    public GameObject objetoTarget;



// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            //Cambio de color
            objetoTarget.GetComponent<Renderer>().material.color = Random.ColorHSV(); 
        }
    }
}
