using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Setingsitem : MonoBehaviour
{
    [HideInInspector] public Image imag;
    [HideInInspector] public Transform trans;


    private void Awake()
    {
        imag = GetComponent<Image>();
        trans = transform;
    }

}
