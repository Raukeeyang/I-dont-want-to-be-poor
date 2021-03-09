using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruteria : MonoBehaviour
{
    public int platanosDar;
    public int uvasDar;
    public int duriansDar;
    public int sandiasDar;
    public int frutaComoldin;

    public Inventory Inventory;
    public void OnTriggerEnter2D()
    {
        Inventory.platanos = 0;
        Inventory.uvas = 0;
        Inventory.durians = 0;
        Inventory.sandias = 0;
        frutaComoldin = platanosDar;
        while (platanosDar > 0)
        {
            Inventory.RecibirFruta(1);
            platanosDar -= 1;
        }
        platanosDar = frutaComoldin;
        frutaComoldin = uvasDar;
        while (uvasDar > 0)
        {
            Inventory.RecibirFruta(2);
            uvasDar -= 1;
        }
        uvasDar = frutaComoldin;
        frutaComoldin = sandiasDar;
        while (duriansDar > 0)
        {
            Inventory.RecibirFruta(3);
            duriansDar -= 1;
        }
        sandiasDar = frutaComoldin;
        frutaComoldin = sandiasDar;
        while (sandiasDar > 0)
        {
            Inventory.RecibirFruta(4);
            sandiasDar -= 1;
        }
        sandiasDar = frutaComoldin;
    }
}
