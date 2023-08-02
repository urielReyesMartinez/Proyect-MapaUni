using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.Animations;


public class Escenas : MonoBehaviour
{
    public GameObject trancicion;
    
    public void CambioEscena2()
    {
        trancicion.SetActive(true);
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
    public void QuitApp()
    {
        Application.Quit();
    }
}
