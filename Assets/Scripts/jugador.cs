using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class jugador : MonoBehaviour
{
    public GameObject objetoTarget;
    [SerializeField]
    int targetSpeed = 10;
    public float jumpForce=3;

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
        if (Input.GetKey(KeyCode.W))
        {
            //Movimiento hacia adelante
            transform.Translate(Vector3.forward * targetSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Movimiento hacia atrás
            transform.Translate(Vector3.back * targetSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Movimiento hacia la Izquierda
            transform.Translate(Vector3.left * targetSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Movimiento hacia la derecha
            transform.Translate(Vector3.right * targetSpeed * Time.deltaTime);
        }
        //Salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Aplicar fuerza vertical para simular el salto
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}
