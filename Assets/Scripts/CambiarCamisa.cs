using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarCamisa : MonoBehaviour
{
   public GameObject buso,buso2,buso3,camisilla,camisilla2,torso;
   private int num;
    void Update()
    {
        if(num == 0){
            buso.SetActive(false);
            torso.SetActive(true);
        }
        if(num == 1){
            buso.SetActive(true);
            torso.SetActive(false);
            buso2.SetActive(false);
        }
        if(num == 2){
            buso2.SetActive(true);
            buso.SetActive(false);
            buso3.SetActive(false);
        }
        if(num == 3){
            buso2.SetActive(false);
            buso3.SetActive(true);
            camisilla.SetActive(false);
        }
        if(num == 4){
            buso3.SetActive(false);
            camisilla.SetActive(true);
	    camisilla2.SetActive(false);
        }
	if(num ==5){
		camisilla.SetActive(false);
		camisilla2.SetActive(true);
	}
    }
    public void izq(){
        if(num>0){
            num -= 1;
        }
    }
    public void der(){
        if(num<5){
            num += 1;
        }
    }
}
