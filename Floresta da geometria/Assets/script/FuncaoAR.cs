using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FuncaoAR : MonoBehaviour
{
   public void girarFormaDireita(){
      GameObject forma = GameObject.Find("ARCamera/FormaFase");
      forma.transform.Rotate(0.0f, 45.0f, 0.0f, Space.Self);
   }
   public void girarFormaEsquerda(){
      GameObject forma = GameObject.Find("ARCamera/FormaFase");
      forma.transform.Rotate(0.0f, 0.0f, 45.0f, Space.Self);
   }
   public void girarFormaParaBaixo(){
      GameObject forma = GameObject.Find("ARCamera/FormaFase");
      forma.transform.Rotate(45.0f, 0.0f, 0.0f, Space.Self);
   }
   public void girarFormaParaCima(){
      GameObject forma = GameObject.Find("ARCamera/FormaFase");
      forma.transform.Rotate(-45.0f, 0.0f, 0.0f, Space.Self);
   }
   public void IrDesafio(){
      SceneManager.LoadScene("CenaPerguntas1");
   }
}
