using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Nav4 : MonoBehaviour
{
    public NavMeshAgent NavAvatar4;
    public GameObject Destino3;
    public GameObject Destino4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Nave4()
    {
        NavAvatar4.destination = Destino3.transform.position;
    }
    public void Nave44()
    {
        NavAvatar4.destination = Destino4.transform.position;
    }

}
