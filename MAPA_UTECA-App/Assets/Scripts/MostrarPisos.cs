using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MostrarPisos : MonoBehaviour
{
    public GameObject Piso2;
    public GameObject Piso4;

    public GameObject Edificio;

    public Rigidbody Quieto;
  

    private void Update()
    {
        Quieto.transform.Rotate(0, 0, 0 * Time.deltaTime);
    }

    public void Piso2_on()
    {
        Piso2.SetActive(true);
        Piso4.SetActive(false);
        Edificio.SetActive(false);
    }
    public void Piso4_on()
    {
        Piso4.SetActive(true);
        Piso2.SetActive(false);
        Edificio.SetActive(false);

    }
    public void Edificio_on()
    {
        Edificio.SetActive(true);
        Piso4.SetActive(false);
        Piso2.SetActive(false);
    }


}
