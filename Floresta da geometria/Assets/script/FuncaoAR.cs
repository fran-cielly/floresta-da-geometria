using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncaoAR : MonoBehaviour
{
   public void girarFormaDireita(){
      GameObject forma = GameObject.Find("ARCamera/FormaFase");
      forma.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
   }
   public void girarFormaEsquerda(){
      GameObject forma = GameObject.Find("ARCamera/FormaFase");
      forma.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
   }
   public void girarFormaParaBaixo(){
      GameObject forma = GameObject.Find("ARCamera/FormaFase");
      forma.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
   }
   public void girarFormaParaCima(){
      GameObject forma = GameObject.Find("ARCamera/FormaFase");
      forma.transform.Rotate(-90.0f, 0.0f, 0.0f, Space.Self);
   }
}
