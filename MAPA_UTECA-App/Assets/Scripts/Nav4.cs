using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Nav4 : MonoBehaviour
{
    public NavMeshAgent NavAvatar;
    public GameObject Destino;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Nave4()
    {
        NavAvatar.destination = Destino.transform.position;
    }

}
