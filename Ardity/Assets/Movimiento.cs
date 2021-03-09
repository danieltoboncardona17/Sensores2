using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public GameObject pajaro;
    public int speed = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Vertical");
        if (y>0) {

            float velocidad = speed * y * Time.deltaTime;
            Vector3 vectorDesplazamiento = Vector3.forward*velocidad;
            
            pajaro.gameObject.transform.position +=vectorDesplazamiento;
        }
    }
}
