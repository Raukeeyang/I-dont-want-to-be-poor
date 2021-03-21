using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int frutasMax;
    public int frutasActuales;
    public int platanos;
    public int uvas;
    public int durians;
    public int sandias;
    public int frutaEquipada;

    public bool smalled = false;
    bool runned = false;

    public CharacterMovement playerM;

    public GameObject bananaPrefab;

    public Transform player;

    public bool recarga;
    public void RecibirFruta(int fruta)
    {
        
        if (frutasMax > frutasActuales)
        {
            switch (fruta)
            {
                case 1:
                    platanos += 1;
                    frutasActuales += 1;
                    break;
                case 2:
                    uvas += 1;
                    frutasActuales += 1;
                    break;
                case 3:
                    sandias += 1;
                    frutasActuales += 1;
                    break;
                case 4:
                    durians += 1;
                    frutasActuales += 1;
                    break;

            }
        }
    }

    

    void Update()
    {
        
        



        switch (frutaEquipada)
        {
            
            case 1:
                if (Input.GetMouseButtonDown(0) && platanos > 0 && recarga == false && runned == false)
                {
                    platanos -= 1;
                    frutasActuales -= 1;
                    StartCoroutine(plataCooldown());
                }
                break;
            case 2:
                if (Input.GetMouseButtonDown(0) && uvas> 0 && recarga == false && smalled == false)
                {
                    uvas -= 1;
                    frutasActuales -= 1;
                    transform.localScale = new Vector2(0.55f, 0.55f);
                    StartCoroutine (uvaCooldown());
                }
                break;
        }


    }

    IEnumerator uvaCooldown()
    {
        smalled = true;
        yield return new WaitForSeconds(15f);
        transform.localScale = new Vector2(1f, 1f);
        smalled = false;
    }

    IEnumerator plataCooldown()
    {
        runned = true;
        playerM.speed += 45;
        yield return new WaitForSeconds(0.2f);
        playerM.speed -= 45;
        runned = false;
    }
}
