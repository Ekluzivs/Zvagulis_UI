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
    public GameObject Dchest;
    public GameObject Ichest;
    public GameObject Achest;
    public GameObject Dchestoff;
    public GameObject Ichestoff;
    public GameObject Achestoff;
    public GameObject Dlegs;
    public GameObject Ilegs;
    public GameObject Alegs;
    public GameObject Dlegsoff;
    public GameObject Ilegsoff;
    public GameObject Alegsoff;
    public GameObject Dboots;
    public GameObject Iboots;
    public GameObject Aboots;
    public GameObject Dbootsoff;
    public GameObject Ibootsoff;
    public GameObject Abootsoff;
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
    public void Diamondchest(bool vertiba){
    Dchest.SetActive(vertiba);
        if(Dchest.activeInHierarchy == true){
        Dchestoff.SetActive(false);
    }else if(Dchest.activeInHierarchy == false){
        Dchestoff.SetActive(true);
    }
    }
    public void Ironchest(bool vertiba){
    Ichest.SetActive(vertiba);
        if(Ichest.activeInHierarchy == true){
        Ichestoff.SetActive(false);
    }else if(Ichest.activeInHierarchy == false){
        Ichestoff.SetActive(true);
    }
    }
        public void leatherchest(bool vertiba){
    Achest.SetActive(vertiba);
        if(Achest.activeInHierarchy == true){
        Achestoff.SetActive(false);
    }else if(Achest.activeInHierarchy == false){
        Achestoff.SetActive(true);
    }
    }
    public void Diamondlegs(bool vertiba){
    Dlegs.SetActive(vertiba);
        if(Dlegs.activeInHierarchy == true){
        Dlegsoff.SetActive(false);
    }else if(Dlegs.activeInHierarchy == false){
        Dlegsoff.SetActive(true);
    }
    }
    public void Ironlegs(bool vertiba){
    Ilegs.SetActive(vertiba);
        if(Ilegs.activeInHierarchy == true){
        Ilegsoff.SetActive(false);
    }else if(Ilegs.activeInHierarchy == false){
        Ilegsoff.SetActive(true);
    }
    }
    public void LeatherLegs(bool vertiba){
    Alegs.SetActive(vertiba);
        if(Alegs.activeInHierarchy == true){
        Alegsoff.SetActive(false);
    }else if(Alegs.activeInHierarchy == false){
        Alegsoff.SetActive(true);
    }
    }
        public void Diamondboots(bool vertiba){
    Dboots.SetActive(vertiba);
        if(Dboots.activeInHierarchy == true){
        Dbootsoff.SetActive(false);
    }else if(Dboots.activeInHierarchy == false){
        Dbootsoff.SetActive(true);
    }
    }
        public void Ironboots(bool vertiba){
    Iboots.SetActive(vertiba);
        if(Iboots.activeInHierarchy == true){
        Ibootsoff.SetActive(false);
    }else if(Iboots.activeInHierarchy == false){
        Ibootsoff.SetActive(true);
    }
    }
            public void Leatherboots(bool vertiba){
    Aboots.SetActive(vertiba);
        if(Aboots.activeInHierarchy == true){
        Abootsoff.SetActive(false);
    }else if(Aboots.activeInHierarchy == false){
        Abootsoff.SetActive(true);
    }
    }
}