using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class irEscenas : MonoBehaviour
{
    [SerializeField] private GameObject botonEscena;
    [SerializeField] private GameObject MenuEscenas;

    [SerializeField] private GameObject PisosON;
    [SerializeField] private GameObject Pisosmost;
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

    public void BotPisos()
    {
        PisosON.SetActive(true);
        Pisosmost.SetActive(true);
        MenuEscenas.SetActive(false);
    }
    public void Escerar()
    {
        PisosON.SetActive(true);
        Pisosmost.SetActive(false);
    }

}
