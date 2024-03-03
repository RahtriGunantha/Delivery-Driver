using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  [SerializeField] Color32 newPackageColor = new Color32();
  [SerializeField] Color32 noPackageColor = new Color32();
  [SerializeField] float waktuHancur;

  bool hasPackage;
  SpriteRenderer spriteRenderer;

  private void Start() {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }
  private void OnCollisionEnter2D(Collision2D other) {
    Debug.Log("Aduh !!");
  }
  private void OnTriggerEnter2D(Collider2D other) {
    
  
  if (other.tag == "Package" && !hasPackage){
    
    Debug.Log("Paket Diambil");
    hasPackage = true;
    spriteRenderer.color = newPackageColor;
    Destroy(other.gameObject, waktuHancur);

  }else
  {
    Debug.Log("Anter Dulu Paket Yang Ini !!");
  }

  if(other.tag == "Customer" && hasPackage){

    Debug.Log("Paket Dikirim");
    hasPackage = false;
    spriteRenderer.color = noPackageColor;
  }

  }
}
