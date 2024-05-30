using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;

    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            desactivarvehiculos();
            vehiculos[Random.Range(0, 6)].SetActive(true);
            
        }   
    }

    void ResetearVehiculos()
    {
        desactivarvehiculos();
    }

    void desactivarvehiculos()
    {
        for (int i = 0; i < vehiculos.Length; i++)
        {
            vehiculos[i].SetActive(false);
        }
    }
}

