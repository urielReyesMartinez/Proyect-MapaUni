using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class irEscenas : MonoBehaviour
{
    [SerializeField] private GameObject botonEscena;
    [SerializeField] private GameObject MenuEscenas;

    public void Mostrar()
    {
        botonEscena.SetActive(true);
        MenuEscenas.SetActive(true);
    }

    public void Cerrar()
    {
        botonEscena.SetActive(true);
        MenuEscenas.SetActive(false);
    }


}
