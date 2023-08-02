using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Nav2 : MonoBehaviour
{

    public NavMeshAgent NavAvatar2;
    public GameObject Destino1;
    public GameObject Destino2;

    // Start is called before the first frame update
    void Start()
    {
        // NavAvatar2.destination = Destino1.transform.position;

    }

    public void Nave2 ()
    {
        NavAvatar2.destination = Destino1.transform.position;
        Debug.Log("leyendo");
    }
    public void Nave22()
    {
        NavAvatar2.destination = Destino2.transform.position;
    }
}
