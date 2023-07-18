using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Edificio : MonoBehaviour
{
    public GameObject Escuela;
    
    public GameObject FrontFace;

    public GameObject BackFace;

    public GameObject LeftFace;

    public GameObject RightFace;

    public GameObject TopFace;

    public Rigidbody BuildBody;


    public void ShowBuild()
    {
        Escuela.SetActive(true);
    }


    public void HideFace()
    {
        FrontFace.SetActive(false);
        BackFace.SetActive(false);
        LeftFace.SetActive(false);
        RightFace.SetActive(false);
        TopFace.SetActive(false);
    }

    private void Update()
    {
        BuildBody.transform.Rotate(0, 40 * Time.deltaTime,0);
    }


    public void ShowFaces()
    {
        FrontFace.SetActive(true);
        BackFace.SetActive(true);
        LeftFace.SetActive(true);
        RightFace.SetActive(true);
        TopFace.SetActive(true);
    }

    public void QuitApp()
    {
        Application.Quit();
    }

}
