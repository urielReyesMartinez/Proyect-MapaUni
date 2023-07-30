using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Setingsmenu : MonoBehaviour
{
    [Header("space between menu items")]
    [SerializeField] Vector3 spacing;

    Button Mainbuton;
    Setingsitem[] menuitem;
    bool isexpanded = false;

    Vector3 Maninbutonposition;
    int itemscount;


    private void Start()
    {
        itemscount = transform.childCount - 1;
        menuitem = new Setingsitem[itemscount];
        for (int i = 0; i < itemscount; i++)
        {
            menuitem[i] = transform.GetChild(i + 1).GetComponent<Setingsitem>();

        }
        Mainbuton = transform.GetChild(0).GetComponent<Button>();
        Mainbuton.onClick.AddListener(TooggleMenu);
        Mainbuton.transform.SetAsLastSibling();

       Maninbutonposition = Mainbuton.transform.position;
        //ToogleMenu();
        ResetPosition();
    }
    private void ResetPosition()
    {
        for (int i = 0; i < itemscount; i++)
        {
            menuitem[i].trans.position = Maninbutonposition;
        }
    }
    private void TooggleMenu()
    {
        isexpanded = !isexpanded;
        if (isexpanded)
        {
            for (int i = 0; i < itemscount; i++)
            {
                menuitem[i].trans.position = Maninbutonposition+ spacing*(i+1);
            }
        }
        else
        {
            for (int i = 0; i < itemscount; i++)
            {
                menuitem[i].trans.position = Maninbutonposition;
            }
        }
    }
    private void OnDestroy()
    {
        Mainbuton.onClick.RemoveListener(TooggleMenu);
    }
}
