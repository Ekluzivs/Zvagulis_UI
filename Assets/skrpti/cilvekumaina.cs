using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cilvekumaina : MonoBehaviour
{
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    // Start is called before the first frame update
public void izkritosais(int skaitlis){
    if(skaitlis==0){
        mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
    }else if (skaitlis==1){
        mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
    }
}
}