
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pokemonballcontroller : MonoBehaviour
{
    bool hasHitPokemon = false;

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Slowpoke" && !hasHitPokemon)
        {
            hasHitPokemon = true;

            Destroy(GameObject.Find("Slowpoke"));

            GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }

        if (hasHitPokemon && other.gameObject.name == "Terrain")
        {
            GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
            GetComponent<Rigidbody>().isKinematic = true;

            GetComponent<ParticleSystem>().Play();
        }
    }

    void Start()
    {
        Application.targetFrameRate = 60;
        //Shoot(new Vector3(650, 300, 0));
    }
}
