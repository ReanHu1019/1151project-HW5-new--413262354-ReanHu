using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PokemonballGenerator : MonoBehaviour
{
    public GameObject PokemonballPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject pokemonball = 
            Instantiate(PokemonballPrefab);
            pokemonball.GetComponent<pokemonballcontroller>().Shoot(
                new Vector3(500, 450, 0));
        }
    }
    
}
