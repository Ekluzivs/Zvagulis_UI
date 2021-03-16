using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vards : MonoBehaviour
{
    string teksts;
    public GameObject ievadlauks;
    public GameObject cauvins;
    string gads;
    public GameObject ievade;
    public GameObject gadins;
 public void uzgabatTekstu(){
     teksts=ievadlauks.GetComponent<Text>().text;
cauvins.GetComponent<Text>().text="Jūsu vārds ir: "+teksts+" un jūs esat "+gads+" vecs/-a";
     gads=ievade.GetComponent<Text>().text;
     gadins.GetComponent<Text>().text="Jūsu vārds ir: "+teksts+" un jūs esat "+gads+" vecs/-a";
 }
}