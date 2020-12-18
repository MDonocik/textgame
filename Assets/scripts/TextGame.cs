using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGame : MonoBehaviour
{
    // Start is called before the first frame update
    int min = 1;
    int max = 1000;
    int guess = 500;
    
    void Start()
    {
        
        Debug.Log("Witaj Graczu");
        Debug.Log("pomysl o liczbie od 1 do 1000");
        Debug.Log("szczalka do gory jezeli liczba jest wieksza niż 500");
        Debug.Log("szczalka w dol jezeli liczba jest mniejsza niż 500");

    }

    // Update is called once per frame
    void Update()
       
    {
        if (input.GetKeyDown(KeyCode.UpArrow));
        {
            print("Jesli twoja liczba jest wieksza od " + guess" kliknij szczalke w gore a jezeli mniejsza szczalke w dol");
                

                 min = guess;
            guess = min + max / 2;

        } 
        if (input.GetKeyDown(KeyCode.DownArrow));
        {
            print("Jesli twoja liczba jest wieksza od " + guess" kliknij szczalke w gore a jezeli mniejsza szczalke w dol");
              
                max = gess;
           guess =  min + max / 2;
        }
        if (input.GetKeyDown(KeyCode.Return));
        {
            print("Wygrałem");
        }
    }
}
