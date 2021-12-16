using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gogame1 : MonoBehaviour
{
    public string scene;
   public void switchscene()
   {
       SceneManager.LoadScene(scene);
   }
}
