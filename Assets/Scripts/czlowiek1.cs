using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class czlowiek1 : MonoBehaviour
{
    public string Name = "Radek";
    private int Wiek1 = 0;


    // Start is called before the first frame update
    void Start()
    {
        czlowiek2 cz2 = new czlowiek2();
        Name = cz2.Name;

        Wiek1 = cz2.Wiek;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
