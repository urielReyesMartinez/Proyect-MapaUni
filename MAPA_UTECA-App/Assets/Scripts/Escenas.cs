using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Escenas : MonoBehaviour
{
   
    public void CambioEscena2()
    {
        SceneManager.LoadScene("Escena 2");
    }
    public void CambioEscena4()
    {
        SceneManager.LoadScene("Escena 4");
    }
    public void RegresarEscena()
    {
        SceneManager.LoadScene("Proyecto");
      
    }
}
