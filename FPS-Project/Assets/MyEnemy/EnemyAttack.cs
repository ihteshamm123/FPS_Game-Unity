using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

 /*public float MaxDistance;
 public float CoolDownTimer;
 public PlayerHealth ph;

 private Transform MyTransform;
 public Transform Target;


 void Start () {
  GameObject go = GameObject.FindGameObjectWithTag ("Player");
  Target = go.transform;
  MyTransform = transform;
  MaxDistance = 3;
  CoolDownTimer = 1;

  ph = (PlayerHealth) go.GetComponent (typeof(PlayerHealth));
 }

 void Update () {
  float distance = Vector3.Distance (Target.position, MyTransform.position);
  if (distance < MaxDistance) {
   Attack ();
  }

  if (CoolDownTimer > 0) {
   CoolDownTimer = CoolDownTimer * Time.deltaTime;
  }
 }

 void Attack () {
  if(CoolDownTimer == 0) {
   ph.ChangeHealth(-10);
   CoolDownTimer = 1;
  }
 }*/
}