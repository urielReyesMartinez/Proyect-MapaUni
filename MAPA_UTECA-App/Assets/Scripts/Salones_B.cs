using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Salones_B : MonoBehaviour
{
    public static Salones_B door;
    
    public List<Renderer> Rooms;

    public Color Room1B;

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
        Room1B = Rooms[0].material.color;
    }

    public void HandleInputData(int option)
    {
        if (option == 1) 
        {
            Rooms[0].material.renderQueue.ToString();  
        }

        if (option == 2)
        {
            Rooms[1].material.color = Color.blue;
        }

    }
}
