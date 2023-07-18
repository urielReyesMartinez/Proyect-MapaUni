using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaChange : MonoBehaviour
{
    [SerializeField] private Material myMaterial;

    private void Start()
    {
        Color color = myMaterial.color;
        color.a = 0;
        myMaterial.color = color;
    }
}