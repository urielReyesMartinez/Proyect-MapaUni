using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Instructivo : MonoBehaviour
{
    public GameObject instructivo;
    //public GameObject Edifcio;

    private void Update()
    {
        instruc();
    }
    public void instruc()
    {
        instructivo.SetActive(true);
        
    }
    public void Ayuda()
    {
       
        instructivo.SetActive(true);
    }
    public void Cerrar()
    {
        instructivo.SetActive(false);
       
    }
    

}
