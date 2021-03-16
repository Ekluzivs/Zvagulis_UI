using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cepures : MonoBehaviour
{
    public GameObject dimanta;
    public GameObject dzelzis;
    public GameObject leather;
    public GameObject dimantaoff;
    public GameObject dzelzisoff;
    public GameObject leatheroff;
public void dimantaattelosana(bool vertiba){
    dimanta.SetActive(vertiba);
    if(dimanta.activeInHierarchy == true){
        dimantaoff.SetActive(false);
    }else if(dimanta.activeInHierarchy == false){
        dimantaoff.SetActive(true);
    }
    }
public void dzelzaAttelosana(bool vertiba){
    dzelzis.SetActive(vertiba);
        if(dzelzis.activeInHierarchy == true){
        dzelzisoff.SetActive(false);
    }else if(dzelzis.activeInHierarchy == false){
        dzelzisoff.SetActive(true);
    }
    }
public void adasAttelosana(bool vertiba){
    leather.SetActive(vertiba);
        if(leather.activeInHierarchy == true){
        leatheroff.SetActive(false);
    }else if(leather.activeInHierarchy == false){
        leatheroff.SetActive(true);
    }
    }
}