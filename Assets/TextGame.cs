using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGame : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int guess = 500;
    void Start()
    {
        Debug.Log("Hello World");
        Debug.Log("Pomysl sobie w glowie liczbe od 1 do 1000 ale nie mow jej na glos");
        Debug.Log("Czy twoja liczba jest wieksza lub mniejsza od 500?");
        Debug.Log("Aby odpowiedziec na pytanie: Gorna strzalka = wyzsza liczba, dolna sztrzalka = nizsza liczba");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
                 min = guess;

            guess = (min + max) / 2;

            print("Czy twoja liczba jest mniejsza lub wieksza od " + guess + " ?");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;

            guess = (min + max) / 2;

            print("Czy twoja liczba jest mniejsza lub wieksza od " + guess + " ?");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {

            print("Wygrales");
        }


    }
}
