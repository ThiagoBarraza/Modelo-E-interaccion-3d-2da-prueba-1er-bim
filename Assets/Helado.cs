using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helado : MonoBehaviour
{
    public string CodigoHelado;
    public int CantidadHelado;
    //si el kilo de helado esta a 500$ eso significa que 1$ = 2g
    
    // Start is called before the first frame update
    void Start()
    {
        if(CodigoHelado == "CHO" || CodigoHelado == "FRU" || CodigoHelado == "DDL" && CantidadHelado <= 250 && CantidadHelado <= 3000)
        {
            float Precio = CantidadHelado / 2;
        }
        else
        {
            Debug.Log("Error, codigo invalido/ cantidad de helado fuera de rango (rango = 250 hasta 3000)");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
