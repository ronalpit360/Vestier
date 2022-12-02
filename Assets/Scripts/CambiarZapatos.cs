using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarZapatos : MonoBehaviour
{
   public GameObject zapatos,zapatos2,zapatos3,pies;
   private int num;
    void Update()
    {
        if(num == 0){
            zapatos.SetActive(false);
            pies.SetActive(true);
        }
        if(num == 1){
            zapatos.SetActive(true);
            pies.SetActive(false);
            zapatos2.SetActive(false);
        }
        if(num == 2){
            zapatos2.SetActive(true);
            zapatos.SetActive(false);
            zapatos3.SetActive(false);
        }
        if(num == 3){
            zapatos2.SetActive(false);
            zapatos3.SetActive(true);
        }
    }
    public void izq(){
        if(num>0){
            num -= 1;
        }
    }
    public void der(){
        if(num<3){
            num += 1;
        }
    }
}
