using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarPantalon : MonoBehaviour
{
   public GameObject pantalon,pantalon2,pantalon3,pantalon4,pantalon5,pantalon6,piernas;
   private int num;
    void Update()
    {
        if(num == 0){
            pantalon.SetActive(false);
            piernas.SetActive(true);
        }
        if(num == 1){
            pantalon.SetActive(true);
            piernas.SetActive(false);
            pantalon2.SetActive(false);
        }
        if(num == 2){
            pantalon2.SetActive(true);
            pantalon.SetActive(false);
	    pantalon3.SetActive(false);
        }
	if(num == 3){
            pantalon3.SetActive(true);
            pantalon2.SetActive(false);
	    pantalon4.SetActive(false);
        }
	if(num == 4){
            pantalon4.SetActive(true);
            pantalon3.SetActive(false);
	    pantalon5.SetActive(false);
        }
	if(num == 5){
            pantalon5.SetActive(true);
            pantalon4.SetActive(false);
	    pantalon6.SetActive(false);
        }
	if(num == 6){
            pantalon6.SetActive(true);
            pantalon5.SetActive(false);
        }
    }
    public void izq(){
        if(num>0){
            num -= 1;
        }
    }
    public void der(){
        if(num<6){
            num += 1;
        }
    }
}
