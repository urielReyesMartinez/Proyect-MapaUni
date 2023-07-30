using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Salones_A : MonoBehaviour
{
    public static Salones_A door;

    public List<Renderer> Rooms;

    public Color Room1A;

    public GameObject piso2;
    public GameObject piso4;
    public Dropdown drop;

    public void Awake()
    {
        if (door == null)
        {
            return;
        }
        else
        {
            door = this;
        }
    }

    public void Start()
    {
        Room1A = Rooms[0].material.color;
    }

    public void HandleInputData(int option)
    {
        if (option == 1) 
        {
            Rooms[0].material.color = Color.green;
            
        }

        if (option == 2)
        {
            Rooms[1].material.color = Color.green;
        }

    }

    public void dropdown(int index)
    {
        if (index==0)
        {
            piso2.SetActive(true);
        }
        else
        {
            piso4.SetActive(true);
        }
    }
}
