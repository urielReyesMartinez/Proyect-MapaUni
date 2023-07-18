using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Nav2 : MonoBehaviour
{

    public NavMeshAgent NavAvatar;
    public GameObject Destino;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Nave2 ()
    {
        NavAvatar.destination = Destino.transform.position;
    }
}
